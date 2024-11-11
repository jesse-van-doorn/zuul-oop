class Player
{
    public Room CurrentRoom { get; set; }

    public int health;
    private int Damage;
    private int Heal;
    private bool IsAlive;

    public Player()
    {
        CurrentRoom = null;
        health = 100;
    }
}