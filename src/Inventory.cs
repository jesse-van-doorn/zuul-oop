class Inventory
{
    private int maxWeight = 10;
    private Dictionary<string, Item> items;
    public Inventory(int maxWeight)
    {
        this.maxWeight = maxWeight;
        this.items = new Dictionary<string, Item>();
    }
    public bool Put(string itemName, Item item)
    {
        // TODO implement:
        // Check the Weight of the Item and check
        // for enough space in the Inventory
        // Does the Item fit?
        // Put Item in the items Dictionary
        // Return true/false for success/failure
        if (item.Weight + TotalWeight() < maxWeight)
        {
            items.Add(itemName , item);
            return true;
        }
        Console.WriteLine("Not enough space");
        return false;
    }

    public Item Get(string itemName)
    {
        // TODO implement:
        // Find Item in items Dictionary
        // remove Item from items Dictionary if found
        // return Item or null
        if (items.ContainsKey(itemName))
        {
            Item item = items[itemName];
            items.Remove(itemName);
            return item;
        }
        return null;
    }

    // methods
    public int TotalWeight()
    {
        int total = 0;
        
        foreach(var item in items.Values)
        {
            total += item.Weight;
        }
        // TODO implement:
        // loop through the items, and add all the weightsreturn total;
        return total;
    }
    public int FreeWeight()
    {
        // TODO implement:
        // compare MaxWeight and TotalWeight()
        int free = maxWeight - TotalWeight();
        return free;
    }
}