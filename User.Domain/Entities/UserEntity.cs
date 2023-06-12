using Common.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Model.DTO;

namespace User.Domain.Entities
{
    public class UserEntity : IBaseEntity<Guid>
    {
        [Key]
        [Column(TypeName = "Uniqueindentifier")]
        public virtual Guid Id { get; set; }
        [Column(TypeName = "NVARCHAR(255)")]
        public virtual string FirstName { get; set; }
        [Column(TypeName = "NVARCHAR(255)")]
        public virtual string LastName { get; set; }
        [Column(TypeName = "VARCHAR(255)")]
        public virtual string Email { get; set; }
        [Column(TypeName = "VARCHAR(255)")]
        public virtual string Password { get; set; }
        [Column(TypeName = "VARCHAR(512)")]
        public virtual string? Avatar { get; set; }
        [Column(TypeName = "DATETIME")]
        public virtual DateTime CreatedAt { get; set; }
        [Column(TypeName = "DATETIME")]
        public virtual DateTime? UpdatedAt { get; set; }

        public UserEntity() { }

        public UserEntity(RegisterUserDTO dto)
        {
            FirstName = dto.FirstName;
            LastName = dto.LastName;
            Email = dto.Email;
            Password = dto.Password;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
