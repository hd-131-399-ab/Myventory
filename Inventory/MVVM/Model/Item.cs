namespace Inventory.MVVM.Model
{
    class Item
    {
        public string Name { get; set; }
        public Image Img { get; set; }
        public string Location { get; set; }

        public Item(string name, Image img, string location)
        {
            Name = name;
            Img = img;
            Location = location;
        }
    }
}
