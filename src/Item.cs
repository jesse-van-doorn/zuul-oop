class Item
{
    public int Weight { get; }
    public string Description { get; }

    public Item(int weight, string description)
    {
        Weight = weight;
        Description = description;
    }

    Item potion = new Item(5, "A healing potion");
}