using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace API.Blog.BackEnd.Domain.Entities
{
    public class Comment
    {
        [Key]
        [Column("IdComment")]
        public Guid Id { get; set; } 
        public string Autor { get; set; }
        public string CurrentComment { get; set; }
        [JsonIgnore]
        public virtual List<RepliedComment> RepliedComments { get; set; }
        public DateTime CriationData { get; set; }
    }
}