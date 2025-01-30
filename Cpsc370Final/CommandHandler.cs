namespace Cpsc370Final;

public class CommandHandler
{
    public static void Handle(Command command)
    {
        switch (States.GetCurrentState())
        {
            case StateType.Clicking:
                ClickingCommandHandler.Handle(command);
                break;
            case StateType.Shopping:
                ShoppingCommandHandler.Handle(command);
                break;
            case StateType.Rivaling:
                RivalingCommandHandler.Handle(command);
                break;
            case StateType.Gambling:
                GamblingCommandHandler.Handle(command);
                break;
        }
    }
}