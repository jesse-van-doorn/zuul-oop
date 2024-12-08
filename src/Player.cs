class Player
{
    public int health;
    public Room CurrentRoom { get; set; }

    private Inventory backpack;
    
    public Player()
    {
        CurrentRoom = null;
        health = 100;

        backpack = new Inventory(20);
    }

    public bool TakeFromChest(string itemName)
    {
        // TODO implement:
        // Remove the Item from the Room
        // Put it in your backpack.
        // Inspect returned values.
        // If the item doesn't fit your backpack, put it back in the chest.
        // Communicate to the user what's happening.
        // Return true/false for success/failure
        return false;
    }

    public bool DropToChest(string itemName)
    {
        // TODO implement:
        // Remove Item from your inventory.
        // Add the Item to the Room
        // Inspect returned values
        // Communicate to the user what's happening
        // Return true/false for success/failure
        return false;
    }

    public void Damage()
    {
        health -= 10;
		Console.WriteLine("You are wounded and lose health.");
    }
    public void heal()
    {
        health += 50;
    }
    public bool IsAlive()
    {
		if (health >= 10)
		{
            return false;
		}
        return true;
    }
}