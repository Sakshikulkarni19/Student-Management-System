﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace student_Management.Data
{
    public class student_ManagementContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public student_ManagementContext() : base("name=student_ManagementContext")
        {
        }

        public System.Data.Entity.DbSet<student_Management.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<student_Management.Models.Administrator> Administrators { get; set; }

        public System.Data.Entity.DbSet<student_Management.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<student_Management.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<student_Management.Models.Enrollment> Enrollments { get; set; }

        public System.Data.Entity.DbSet<student_Management.Models.Grade> Grades { get; set; }

        public System.Data.Entity.DbSet<student_Management.Models.Teacher> Teachers { get; set; }

        public System.Data.Entity.DbSet<student_Management.Models.Transcript> Transcripts { get; set; }
    }
}
