using Channel.Model.DTO;
using Common.Entities;
using Common.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Channel.Domain.Entities
{
    [Table("Channel")]
    public class ChannelEntity : IBaseEntity<Guid>
    {
        public virtual Guid Id { get; set; }
        public virtual string ChannelName { get; set; }
        public virtual string Avatar { get; set; }
        public virtual string InvitationCode { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        [Column(TypeName = "CHAR(36)")]
        public virtual Guid CreatedBy { get; set; }
        public virtual DateTime? UpdatedAt { get; set; }
        [Column(TypeName = "CHAR(36)")]
        public virtual Guid? UpdatedBy { get; set; }

        public ChannelEntity() { }

        public ChannelEntity(string name, string avatar, Guid createdBy)
        {
            ChannelName = name;
            Avatar = avatar;
            InvitationCode = StringExtension.RandomString(15);
            CreatedAt = DateTime.UtcNow;
            CreatedBy = createdBy;
        }

        public void Update(ChannelDTO dto)
        {
            ChannelName = dto.Name;
            Avatar = dto.Avatar;
            UpdatedAt = DateTime.UtcNow;
            UpdatedBy = dto.CreatedBy;
        }
    }
}
