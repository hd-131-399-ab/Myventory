namespace Inventory.MVVM.Model
{
    class Situation
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Item[] Items { get; set; }

        public Situation(string name, string description, Item[] items)
        {
            Name = name;
            Description = description;
            Items = items;
        }
    }
}
