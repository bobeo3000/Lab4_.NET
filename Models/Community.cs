using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Models
{
    public class Community
    {
        [Required]
        [Display(Name = "Registration Number")]
        public string ID { get; internal set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; internal set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }

        public IEnumerable<CommunityMembership> CommunityMemberships
        {
            get;
            set;
        }
    }
}
