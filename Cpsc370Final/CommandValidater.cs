namespace Cpsc370Final;

public class CommandValidater
{
    public static Command ValidateCommand(Command command)
    {
        switch (States.GetCurrentState())
        {
            case StateType.Clicking:
                return ClickingCommandValidater.Validate(command);
                break;
            case StateType.Shopping:
                return ShoppingCommandValidater.Validate(command);
                break;
            case StateType.Rivaling:
                return RivalingCommandValidater.Validate(command);
                break;
            case StateType.Gambling:
                return GamblingCommandValidater.Validate(command);
                break;
        }
        return new Command();
    }
}