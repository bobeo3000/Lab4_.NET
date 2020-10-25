using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Models
{
    public class CommunityMembership 
    {
        public int StudentID
        {
            set;
            get;
        }

        public string CommunityID
        {
            set;
            get;
        }

        public Student Student
        {
            get;
            set;
        }

        public Community Community
        {
            get;
            set;
        }
    }
}
