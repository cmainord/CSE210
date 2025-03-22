public class Animation
{
    //private int _fullDuration;

    private List<string> _states;
    private int _currentStateIndex;
    private string _currentState;
    private int _stateDuration; //duration in milliseconds of a single animation state.
    private DateTime _endTime;

    public Animation(List<string> states, int stateDuration = 200)
    {
        _states = states;
        _currentStateIndex = 0;
        _currentState = _states[_currentStateIndex];
        _stateDuration = stateDuration;
        _endTime = DateTime.Now.AddMilliseconds(_stateDuration);
    }

    public string Display()
    {

        if (DateTime.Now > _endTime)
        {
            _endTime = DateTime.Now.AddMilliseconds(_stateDuration);
            NextState();
        }

        return _currentState;
    }

    public void AddStates(string state)
    {
        _states.Add(state);
    }

    private void NextState()
    {
        _currentStateIndex += 1;
        if(_currentStateIndex > _states.Count-1)
        {
            _currentStateIndex = 0;
        }

        _currentState = _states[_currentStateIndex];
    }

    

}