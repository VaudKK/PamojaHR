using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM.Models
{
    public record BaseModel
    {

        [Column("created_at")]
        public DateTimeOffset CreatedAt { get; init; }

        [Column("modified_at")]
        public DateTimeOffset ModifiedAt { get; init; }

    }
}