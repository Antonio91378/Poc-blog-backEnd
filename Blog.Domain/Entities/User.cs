

using API.Blog.BackEnd.Domain.Enum;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace API.Blog.BackEnd.Domain.Entities
{
    public class User
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("codigoUser")]
        [BsonRepresentation(BsonType.Int32)]
        public int CodigoUser { get; set; }

        [BsonElement("email")]
        [BsonRepresentation(BsonType.String)]
        public string Email { get; set; }

        [BsonElement("nome")]
        [BsonRepresentation(BsonType.String)]
        public string Nome { get; set; }

        [BsonElement("password")]
        [BsonRepresentation(BsonType.String)]
        public string PassWord { get; set; }

    }
}