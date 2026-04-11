using System;

class Program
{
 static int score = 0;
    static List<Goal> goals = new List<Goal>();

    // Titles for levels
    static string[] levelTitles = {
        "Novice Seeker",
        "Apprentice Disciple",
        "Temple Knight",
        "Scripture Scholar",
        "Ninja Unicorn",
        "Eternal Champion"
    };

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine($"\nYour score: {score}");            
            Console.WriteLine($"Level: {GetLevel()} – {GetTitle()}");
            
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Quit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": RecordEvent(); break;
                case "3": ShowGoals(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": running = false; break;
            }
        }
    }

        // Calculate level: every 1000 points = new level
    static int GetLevel()
    {
        return (score / 1000) + 1;
    }

    // Get title based on level
    static string GetTitle()
    {
        int level = GetLevel();
        if (level <= levelTitles.Length)
            return levelTitles[level - 1];
        else
            return "Legendary Hero"; // fallback for very high levels
    }
    static void CreateGoal()
    {
        Console.WriteLine("Choose goal type: 1=Simple, 2=Eternal, 3=Checklist");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
            goals.Add(new SimpleGoal(name, desc, points));
        else if (type == "2")
            goals.Add(new EternalGoal(name, desc, points));
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    static void RecordEvent()
    {
        ShowGoals();
        Console.Write("Select goal #: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < goals.Count)
        {
            int earned = goals[index].RecordEvent();
            score += earned;
            Console.WriteLine($"You earned {earned} points!");
        }
    }

    static void ShowGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].DisplayStatus()}");
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            sw.WriteLine(score);
            foreach (var goal in goals)
            {
                sw.WriteLine(goal.GetType().Name + "|" + goal.Name + "|" + goal.Description + "|" + goal.Points);
            }
        }
        Console.WriteLine("Goals saved!");
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            goals.Clear();
            string[] lines = File.ReadAllLines("goals.txt");
            score = int.Parse(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);

                if (type == "SimpleGoal")
                    goals.Add(new SimpleGoal(name, desc, points));
                else if (type == "EternalGoal")
                    goals.Add(new EternalGoal(name, desc, points));
                else if (type == "ChecklistGoal")
                    goals.Add(new ChecklistGoal(name, desc, points, 5, 500)); // default values
            }
            Console.WriteLine("Goals loaded!");
        }
    }
}
