﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Commands
{
    public class CreateCourseCommand : CourseCommand
    {
        public CreateCourseCommand(string name,string desccription, string imageUrl)
        {
            Name = name;
            Description = desccription;
            ImageUrl = imageUrl;
        }
    }
}
