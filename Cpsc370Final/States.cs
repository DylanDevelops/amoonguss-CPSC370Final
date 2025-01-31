namespace Cpsc370Final;

public class States
{
    private static State CurrentState;
    private static Dictionary<StateType, State> states = new Dictionary<StateType, State>();

    public static void Initialize()
    {
        AddState(StateType.Clicking);
        AddState(StateType.Shopping);
        AddState(StateType.Rivaling);
        AddState(StateType.Gambling);
        CurrentState = states[StateType.Clicking];
    }

    public static StateType GetCurrentState()
    {
        return CurrentState.Type;
    }

    private static void AddState(StateType type)
    {
        State state = new State(type);
        if (!states.ContainsKey(state.Type))
        {
            states[state.Type] = state;
        }
    }

    public static void ChangeState(StateType type)
    {
        if (!states.ContainsKey(type))
        {
            IO.Error($"No state of type {type} exists.");
            return;
        }
        else
        {
            CurrentState.Deactivate();
            CurrentState = states[type];
            CurrentState.Activate();
            Debugger.Write("Entering state: " + CurrentState.Type);
        }
    }
}