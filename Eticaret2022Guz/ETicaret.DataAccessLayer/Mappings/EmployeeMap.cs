using Eticaret.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaret.DataAccesLayer.Mappings
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {


            builder.Property(x => x.EmployeeId).HasDefaultValue(0);
            builder.Property(x => x.EmployeeStatu).HasDefaultValue(true);
            builder.Property(x => x.EmployeeName).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.EmployeeUserName).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.EmployeeLastname).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.EmployeeEmail).HasColumnType("varchar").HasMaxLength(100).IsRequired();

            builder.HasData(new Employee
            {
                EmployeeId = 1,
                EmployeeStatu = true,
                EmployeeName = "deneme",
                EmployeeUserName = "deneme",
                EmployeeLastname = "deneme",
                EmployeeEmail="sajksajf@gmail.com"


            });
        }
    }
}
