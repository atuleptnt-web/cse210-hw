// Checklist goal: requires multiple completions
class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        int earned = Points;
        if (_currentCount == _targetCount)
        {
            earned += _bonus;
        }
        return earned;
    }

    public override string DisplayStatus()
    {
        bool complete = _currentCount >= _targetCount;
        return $"{(complete ? "[X]" : "[ ]")} {Name} ({Description}) - Completed {_currentCount}/{_targetCount}";
    }
}
