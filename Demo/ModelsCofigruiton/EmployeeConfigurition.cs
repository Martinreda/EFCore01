using Demo.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ModelsCofigruiton
{
    // Fluent Apis Inside Another Class 
    //You must Implement Built-in Interface EntityTypeConfigriution<>
    internal class EmployeeConfigurition : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            //Assign Fluent APIS 
            builder.HasKey(E => E.id); //PK
            builder.Property(E => E.id)
                .UseIdentityColumn(1, 1);

            builder.Property(E => E.Name)
                .HasColumnName("EmpName")
                .HasColumnType("varchar (50)")
                .HasMaxLength(40)
                .IsRequired(false);
        }
    }
}
