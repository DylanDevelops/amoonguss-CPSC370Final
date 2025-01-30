namespace Cpsc370Final;

public static class Rivals
{
    public static bool hasRivals = false;
    public static bool inRivals = false;
    public static double sandieChangeAmount = SandieBank.SandieCount * 0.1;


    private static void Reset()
    {
        inRivals = false;
        sandieChangeAmount = SandieBank.SandieCount * 0.1;

    }

    public static void StartGame(string ClassSelection)
    {
        inRivals = true;
        if (ClassSelection == "support")
        {
            healerMatch();
        }
        else if (ClassSelection == "dps")
        {
            dpsMatch();
        }
        else if (ClassSelection == "tank")
        {
            tankMatch();
        }
    }

    private static void healerMatch()
    {
        if (inRivals)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 6);

            switch (randomNumber)
            {
                case 1:

                    IO.WriteLine("You picked healer.");
                    IO.WriteLine("Unfortunately the rest of your team chose dps");
                    IO.WriteLine("You try your best to keep them alive");
                    IO.WriteLine("But despite your best efforts you still lose");
                    IO.WriteLine("One of your teammates blames you for losing and calls you some slurs");
                    IO.WriteLine("you lose " + (int)sandieChangeAmount + " sandies");
                    SandieBank.removeSandiesFromBank((int)sandieChangeAmount);
                    break;
                case 2:
                    IO.WriteLine("You picked healer.");
                    IO.WriteLine("Unfortunately the rest of your team chose dps");
                    IO.WriteLine("You try your best to keep them alive");
                    IO.WriteLine("and you do somehow");
                    IO.WriteLine("Your team wins even though the rest of your team honmestly didnt deserve to win");
                    IO.WriteLine("you gain " + (int)sandieChangeAmount + " sandies");
                    SandieBank.addSandiesToBank((int)sandieChangeAmount);
                    break;
                case 3:
                    IO.WriteLine("You picked healer.");
                    IO.WriteLine("You end up on a team with a balanced team comp");
                    IO.WriteLine("Your team easily beats the opposing team");
                    IO.WriteLine("you gain " + (int)sandieChangeAmount + " sandies");
                    SandieBank.addSandiesToBank((int)sandieChangeAmount);
                    break;
                case 4:
                    IO.WriteLine("You picked healer.");
                    IO.WriteLine("You end up on a team with a balanced team comp");
                    IO.WriteLine("The opposing team also has a balanced team comp");
                    IO.WriteLine("Your team trys its best but you end up losing");
                    IO.WriteLine("you lose " + (int)sandieChangeAmount + " sandies");
                    SandieBank.removeSandiesFromBank((int)sandieChangeAmount);
                    break;
                case 5:
                    IO.WriteLine("You picked healer.");
                    IO.WriteLine("You end up on a team with a balanced team comp");
                    IO.WriteLine("The opposing team also has a balanced team comp");
                    IO.WriteLine("It's a tough match but you end up winning");
                    IO.WriteLine("you gain " + (int)sandieChangeAmount + " sandies");
                    SandieBank.addSandiesToBank((int)sandieChangeAmount);
                    break;
            }
        }
        Game.Play();
    }
    
    private static void dpsMatch()
    {
        if (inRivals)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);

            switch (randomNumber)
            {
                case 1:

                    IO.WriteLine("You picked dps.");
                    IO.WriteLine("Unfortunately the rest of your team chose dps");
                    IO.WriteLine("None of you decide to switch roles and you end up losing");
                    IO.WriteLine("One of your teammates blames you for losing and calls you some slurs");
                    IO.WriteLine("you lose " + (int)sandieChangeAmount + " sandies");
                    SandieBank.removeSandiesFromBank((int)sandieChangeAmount);
                    break;
                case 2:
                    IO.WriteLine("You picked dps.");
                    IO.WriteLine("You end up on a team with a balanced team comp");
                    IO.WriteLine("The opposing team also has a balanced team comp");
                    IO.WriteLine("Your team trys its best but you end up losing");
                    IO.WriteLine("you lose " + (int)sandieChangeAmount + " sandies");
                    SandieBank.removeSandiesFromBank((int)sandieChangeAmount);
                    break;
                case 3:
                    IO.WriteLine("You picked dps.");
                    IO.WriteLine("You end up on a team with a balanced team comp");
                    IO.WriteLine("The opposing team also has a balanced team comp");
                    IO.WriteLine("It's a tough match but you end up winning");
                    IO.WriteLine("you gain " + (int)sandieChangeAmount + " sandies");
                    SandieBank.addSandiesToBank((int)sandieChangeAmount);
                    break;
            }
        }
        Game.Play();
    }
    
    private static void tankMatch()
    {
        if (inRivals)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 6);

            switch (randomNumber)
            {
                case 1:

                    IO.WriteLine("You picked tank.");
                    IO.WriteLine("Unfortunately the rest of your team chose dps");
                    IO.WriteLine("You try your best to block most of the damage");
                    IO.WriteLine("But despite your best efforts you still lose");
                    IO.WriteLine("One of your teammates blames you for losing and calls you some slurs");
                    IO.WriteLine("you lose " + (int)sandieChangeAmount + " sandies");
                    SandieBank.removeSandiesFromBank((int)sandieChangeAmount);
                    break;
                case 2:
                    IO.WriteLine("You picked tank.");
                    IO.WriteLine("Unfortunately the rest of your team chose dps");
                    IO.WriteLine("You try your best to block most of the damage");
                    IO.WriteLine("and you do somehow");
                    IO.WriteLine("Your team wins even though the rest of your team honmestly didnt deserve to win");
                    IO.WriteLine("you gain " + (int)sandieChangeAmount + " sandies");
                    SandieBank.addSandiesToBank((int)sandieChangeAmount);
                    break;
                case 3:
                    IO.WriteLine("You picked tank.");
                    IO.WriteLine("You end up on a team with a balanced team comp");
                    IO.WriteLine("Your team easily beats the opposing team");
                    IO.WriteLine("you gain " + (int)sandieChangeAmount + " sandies");
                    SandieBank.addSandiesToBank((int)sandieChangeAmount);
                    break;
                case 4:
                    IO.WriteLine("You picked tank.");
                    IO.WriteLine("You end up on a team with a balanced team comp");
                    IO.WriteLine("The opposing team also has a balanced team comp");
                    IO.WriteLine("Your team trys its best but you end up losing");
                    IO.WriteLine("you lose " + (int)sandieChangeAmount + " sandies");
                    SandieBank.removeSandiesFromBank((int)sandieChangeAmount);
                    break;
                case 5:
                    IO.WriteLine("You picked tank.");
                    IO.WriteLine("You end up on a team with a balanced team comp");
                    IO.WriteLine("The opposing team also has a balanced team comp");
                    IO.WriteLine("It's a tough match but you end up winning");
                    IO.WriteLine("you gain " + (int)sandieChangeAmount + " sandies");
                    SandieBank.addSandiesToBank((int)sandieChangeAmount);
                    break;
            }
        }
        Game.Play();
    }
    
}