﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace HealthCatalystPeopleSearch.Models
{
    public class Person 
    {
        //displaying at least name, address, age, interests, and a picture
        public int Id { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        public string address { get; set; }
        public int? age { get; set; }
        public string interests { get; set; }
        public byte[] byteArr { get; set; } 
        [NotMapped]
        public Image image { get; set; }
    }
}
