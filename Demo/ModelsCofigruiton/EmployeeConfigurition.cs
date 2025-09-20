using Demo.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ModelsCofigruiton
{
    // Fluent Apis Inside Another Class 
    //You must Implement Built-in Interface EntityTypeConfigriution<>
    public class EmployeeConfigurition : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            //Assign Fluent APIS 
            builder.HasKey(E => E.Id); //PK
            builder.Property(E => E.Id)
                .UseIdentityColumn(1, 1);

            builder.Property(E => E.Name)
                .HasColumnName("EmpName")
                .HasColumnType("varchar (50)")
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(e => e.Salary)
              .HasColumnType("decimal(18,2)");

            //one to one t   t 
            builder.OwnsOne(E => E.EmpAddress, Address => Address.WithOwner());

            // one to Many 
            builder
               .HasOne(E => E.EmployeeDepartment)
               .WithMany(D => D.employees)
               .HasForeignKey(E => E.DeptId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
