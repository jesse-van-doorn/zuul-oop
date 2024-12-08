class Player
{
    public int health;
    public Room CurrentRoom { get; set; }
    
    public Player()
    {
        CurrentRoom = null;
        health = 100;
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