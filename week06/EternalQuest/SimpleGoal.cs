// Simple goal: one-time completion
class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return Points;
        }
        return 0;
    }

    public override string DisplayStatus()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {Name} ({Description})";
    }
}
