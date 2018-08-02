using MongoDB.Bson;

namespace WpfHeroClient.Models
{
    public class Hero
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public ObjectId _id { get; set; }
    }
}
