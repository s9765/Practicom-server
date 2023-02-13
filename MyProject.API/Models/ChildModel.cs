﻿using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.API.Models
{
    public class ChildModel
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Tz { get; set; }
        public int ParentId { get; set; }   
}
}
