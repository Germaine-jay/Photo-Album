﻿using ImageApp.DAL.Entities;
using ImageApp.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageApp.BLL.Models
{
	public class UserWithPicturesVM
	{
        public string? Id { get; set; }
        public string? UserName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string? Age { get; set; }
        public string? Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string? ProfileImagePath { get; set; }
        public IEnumerable<Picture>? Pictures { get; set; }
    }
}
