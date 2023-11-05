﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Varga_Paul_Lab2_0.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }


    }
}