using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Channel.Model.DTO
{
    public class ChannelDTO
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Avatar { get; set; }
        public Guid CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}