using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace API.Blog.BackEnd.Domain.Entities
{
    public class Post
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("autor")]
        [BsonRepresentation(BsonType.String)]
        public string Autor { get; set; }
        [BsonElement("codigoPost")]
        [BsonRepresentation(BsonType.Int32)]
        public int CodigoPost { get; set; }
        [BsonElement("title")]
        [BsonRepresentation(BsonType.String)]
        public string Title { get; set; }
        [BsonElement("content")]
        [BsonRepresentation(BsonType.String)]
        public string Content { get; set; }
        [BsonElement("tags")]
        public List<string> Tags { get; set; }
    }
}