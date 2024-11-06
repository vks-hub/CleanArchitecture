using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.CodeAnalysis;

namespace CleanArch.Infra.Data
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}
