namespace La_mia_pizzeria_Model.Models
{
    public class Pizze
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public Pizze(int id, string title, string description, string image)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
        }
    }
}
