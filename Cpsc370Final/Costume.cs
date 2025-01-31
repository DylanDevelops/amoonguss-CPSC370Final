namespace Cpsc370Final;

public static class Costume
{
    public static  void showCostume()
    {
        if (SandieBank.SandieCount != 0)
        {
            if (SandieBank.SandieCount == 1)
            {
                IO.WriteLine("your sandie is wearing a sandie the water corgi costume from the hit game sandie rivals.");
            }
            else if (Inventory.CostumeNumber == 1)
            {
                IO.WriteLine("your sandies are wearing a sandie the water corgi costume from the hit game sandie rivals.");
            }
            else if (Inventory.CostumeNumber == 2)
            {
                IO.WriteLine("Some of your sandies are wearing a sandie the water corgi costume from the hit game sandie rivals.");
                IO.WriteLine("Some of your sandies are wearing a hot dog outfit.");
            }
            else if (Inventory.CostumeNumber == 3)
            {
                IO.WriteLine("Some of your sandies are wearing a sandie the water corgi costume from the hit game sandie rivals.");
                IO.WriteLine("Some of your sandies are wearing a hot dog outfit.");
                IO.WriteLine("Some of your sandies are wearing a beer bottle costume.");
                
            }
            else if (Inventory.CostumeNumber == 4)
            {
                IO.WriteLine("Some of your sandies are wearing a sandie the water corgi costume from the hit game sandie rivals.");
                IO.WriteLine("Some of your sandies are wearing a hot dog costume.");
                IO.WriteLine("Some of your sandies are wearing a beer bottle costume.");
                IO.WriteLine("Some of your sandies are wearing a bumble bee costume");
            }
            else if (Inventory.CostumeNumber == 5)
            {
                IO.WriteLine("Some of your sandies are wearing a sandie the water corgi costume from the hit game sandie rivals.");
                IO.WriteLine("Some of your sandies are wearing a hot dog costume.");
                IO.WriteLine("Some of your sandies are wearing a beer bottle costume.");
                IO.WriteLine("Some of your sandies are wearing a bumble bee costume");
                IO.WriteLine("Some of your sandies are wearing a cowboy costume.");
            }
            else if (Inventory.CostumeNumber == 6)
            {
                IO.WriteLine("Some of your sandies are wearing a sandie the water corgi costume from the hit game sandie rivals.");
                IO.WriteLine("Some of your sandies are wearing a hot dog costume.");
                IO.WriteLine("Some of your sandies are wearing a beer bottle costume.");
                IO.WriteLine("Some of your sandies are wearing a bumble bee costume");
                IO.WriteLine("Some of your sandies are wearing a cowboy costume.");
                IO.WriteLine("Some of your sandies are wearing a chewbacca costume");
            }
            else if (Inventory.CostumeNumber == 7)
            {
                IO.WriteLine("Some of your sandies are wearing a sandie the water corgi costume from the hit game sandie rivals.");
                IO.WriteLine("Some of your sandies are wearing a hot dog costume.");
                IO.WriteLine("Some of your sandies are wearing a beer bottle costume.");
                IO.WriteLine("Some of your sandies are wearing a bumble bee costume");
                IO.WriteLine("Some of your sandies are wearing a cowboy costume.");
                IO.WriteLine("Some of your sandies are wearing a chewbacca costume");
                IO.WriteLine("Some of your sandies are wearing a yamper costume from pokemon");
            }
            else if (Inventory.CostumeNumber == 8)
            {
                IO.WriteLine("Some of your sandies are wearing a sandie the water corgi costume from the hit game sandie rivals.");
                IO.WriteLine("Some of your sandies are wearing a hot dog costume.");
                IO.WriteLine("Some of your sandies are wearing a beer bottle costume.");
                IO.WriteLine("Some of your sandies are wearing a bumble bee costume");
                IO.WriteLine("Some of your sandies are wearing a cowboy costume.");
                IO.WriteLine("Some of your sandies are wearing a chewbacca costume");
                IO.WriteLine("Some of your sandies are wearing a yamper costume from pokemon");
                IO.WriteLine("Some of your sandies are wearing a zombie costume.");
            }
            else if (Inventory.CostumeNumber == 9)
            {
                IO.WriteLine("Some of your sandies are wearing a sandie the water corgi costume from the hit game sandie rivals.");
                IO.WriteLine("Some of your sandies are wearing a hot dog costume.");
                IO.WriteLine("Some of your sandies are wearing a beer bottle costume.");
                IO.WriteLine("Some of your sandies are wearing a bumble bee costume");
                IO.WriteLine("Some of your sandies are wearing a cowboy costume.");
                IO.WriteLine("Some of your sandies are wearing a chewbacca costume");
                IO.WriteLine("Some of your sandies are wearing a yamper costume from pokemon");
                IO.WriteLine("Some of your sandies are wearing a zombie costume.");
                IO.WriteLine("Some of your sandies are wearing a dylan michael ravel costume.");
            }
            else if (Inventory.CostumeNumber == 10)
            {
                IO.WriteLine("Some of your sandies are wearing a sandie the water corgi costume from the hit game sandie rivals.");
                IO.WriteLine("Some of your sandies are wearing a hot dog costume.");
                IO.WriteLine("Some of your sandies are wearing a beer bottle costume.");
                IO.WriteLine("Some of your sandies are wearing a bumble bee costume");
                IO.WriteLine("Some of your sandies are wearing a cowboy costume.");
                IO.WriteLine("Some of your sandies are wearing a chewbacca costume");
                IO.WriteLine("Some of your sandies are wearing a yamper costume from pokemon");
                IO.WriteLine("Some of your sandies are wearing a zombie costume.");
                IO.WriteLine("Some of your sandies are wearing a dylan michael ravel costume.");
                IO.WriteLine("Some of your sandies are wearing a yoshi costume from mario.");
            }
            else
            {
                IO.WriteLine("Your sandies are not wearing a costume.");
            }
        }
        else
        {
            IO.WriteLine("You don't have any sandies right now");
        }
    }
}