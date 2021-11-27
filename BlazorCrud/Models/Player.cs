using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BlazorCrud.Models
{
    public class Player
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        [BsonRepresentation(BsonType.Int32, AllowTruncation = true)]
        public int Number { get; set; }

        public string Position { get; set; }

        [BsonRepresentation(BsonType.Double, AllowTruncation = true)]
        public double Points { get; set; }

        [BsonRepresentation(BsonType.Double, AllowTruncation = true)]
        public double Assists { get; set; }

        [BsonRepresentation(BsonType.Double, AllowTruncation = true)]
        public double Rebounds { get; set; }
    }
}
