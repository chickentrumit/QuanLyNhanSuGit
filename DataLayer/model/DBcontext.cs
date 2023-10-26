using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataLayer.model
{
    public partial class DBcontext : DbContext
    {
        public DBcontext()
            : base("name=DBcontext")
        {
        }

        public virtual DbSet<tb_Account> tb_Account { get; set; }
        public virtual DbSet<tb_AccountPermission> tb_AccountPermission { get; set; }
        public virtual DbSet<tb_AllowanceJob> tb_AllowanceJob { get; set; }
        public virtual DbSet<tb_Department> tb_Department { get; set; }
        public virtual DbSet<tb_Employee> tb_Employee { get; set; }
        public virtual DbSet<tb_EmployeeAllowanceJob> tb_EmployeeAllowanceJob { get; set; }
        public virtual DbSet<tb_EmployeeDiscipline> tb_EmployeeDiscipline { get; set; }
        public virtual DbSet<tb_EmployeePayperiod> tb_EmployeePayperiod { get; set; }
        public virtual DbSet<tb_EmployeePromotionTranfer> tb_EmployeePromotionTranfer { get; set; }
        public virtual DbSet<tb_EmployeeReward> tb_EmployeeReward { get; set; }
        public virtual DbSet<tb_EmployeeSalaryIncrease> tb_EmployeeSalaryIncrease { get; set; }
        public virtual DbSet<tb_EmplymentContract> tb_EmplymentContract { get; set; }
        public virtual DbSet<tb_HealthInsurance> tb_HealthInsurance { get; set; }
        public virtual DbSet<tb_JobType> tb_JobType { get; set; }
        public virtual DbSet<tb_PayPeriod> tb_PayPeriod { get; set; }
        public virtual DbSet<tb_PermissionList> tb_PermissionList { get; set; }
        public virtual DbSet<tb_Position> tb_Position { get; set; }
        public virtual DbSet<tb_ProgramParameters> tb_ProgramParameters { get; set; }
        public virtual DbSet<tb_Resignation> tb_Resignation { get; set; }
        public virtual DbSet<tb_SalaryAdvance> tb_SalaryAdvance { get; set; }
        public virtual DbSet<tb_SalaryCalculation> tb_SalaryCalculation { get; set; }
        public virtual DbSet<tb_ShiftType> tb_ShiftType { get; set; }
        public virtual DbSet<tb_SocialInsurance> tb_SocialInsurance { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tb_Account>()
                .HasMany(e => e.tb_AccountPermission)
                .WithRequired(e => e.tb_Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_AccountPermission>()
                .HasMany(e => e.tb_PermissionList)
                .WithRequired(e => e.tb_AccountPermission)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_AllowanceJob>()
                .HasMany(e => e.tb_EmployeeAllowanceJob)
                .WithRequired(e => e.tb_AllowanceJob)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_Department>()
                .HasMany(e => e.tb_EmployeePromotionTranfer)
                .WithRequired(e => e.tb_Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_Employee>()
                .Property(e => e.EmployeeID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_Employee>()
                .HasMany(e => e.tb_EmployeeAllowanceJob)
                .WithRequired(e => e.tb_Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_Employee>()
                .HasMany(e => e.tb_EmployeePayperiod)
                .WithRequired(e => e.tb_Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_Employee>()
                .HasMany(e => e.tb_EmployeeSalaryIncrease)
                .WithRequired(e => e.tb_Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_Employee>()
                .HasMany(e => e.tb_EmplymentContract)
                .WithRequired(e => e.tb_Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_EmployeeAllowanceJob>()
                .Property(e => e.EmployeeID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_EmployeeDiscipline>()
                .Property(e => e.EmployeeDisciplineID)
                .IsUnicode(false);

            modelBuilder.Entity<tb_EmployeeDiscipline>()
                .Property(e => e.EmployeeID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_EmployeePayperiod>()
                .Property(e => e.EmployeeID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_EmployeePromotionTranfer>()
                .Property(e => e.EmployeeID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_EmployeeReward>()
                .Property(e => e.EmployeeRewardID)
                .IsUnicode(false);

            modelBuilder.Entity<tb_EmployeeReward>()
                .Property(e => e.EmployeeID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_EmployeeSalaryIncrease>()
                .Property(e => e.EmployeeID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_EmplymentContract>()
                .Property(e => e.EmploymentContracID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_EmplymentContract>()
                .Property(e => e.EmployeeID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_HealthInsurance>()
                .Property(e => e.HealthInsuranceID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_HealthInsurance>()
                .Property(e => e.EmployeeID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_PayPeriod>()
                .HasMany(e => e.tb_EmployeeAllowanceJob)
                .WithRequired(e => e.tb_PayPeriod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_PayPeriod>()
                .HasMany(e => e.tb_EmployeePayperiod)
                .WithRequired(e => e.tb_PayPeriod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_PayPeriod>()
                .HasMany(e => e.tb_EmployeeReward)
                .WithRequired(e => e.tb_PayPeriod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_Position>()
                .HasMany(e => e.tb_EmployeePromotionTranfer)
                .WithRequired(e => e.tb_Position)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_Resignation>()
                .Property(e => e.EmployeeID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_SalaryAdvance>()
                .Property(e => e.EmployeeID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_SalaryCalculation>()
                .Property(e => e.EmployeeID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_SocialInsurance>()
                .Property(e => e.EmployeeID)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
