using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OneWealth.Repository.DataModels;

namespace OneWealth.Repository.Data;

public partial class OneWealthContext : DbContext
{
    public OneWealthContext()
    {
    }

    public OneWealthContext(DbContextOptions<OneWealthContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BankInstruction> BankInstructions { get; set; }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<Card> Cards { get; set; }

    public virtual DbSet<CreditCard> CreditCards { get; set; }

    public virtual DbSet<DebitCard> DebitCards { get; set; }

    public virtual DbSet<EquityInvestment> EquityInvestments { get; set; }

    public virtual DbSet<Expense> Expenses { get; set; }

    public virtual DbSet<ExpenseSplit> ExpenseSplits { get; set; }

    public virtual DbSet<Family> Families { get; set; }

    public virtual DbSet<FamilyMember> FamilyMembers { get; set; }

    public virtual DbSet<FixedDepositInvestment> FixedDepositInvestments { get; set; }

    public virtual DbSet<InsuranceInvestment> InsuranceInvestments { get; set; }

    public virtual DbSet<Investment> Investments { get; set; }

    public virtual DbSet<InvestmentTransaction> InvestmentTransactions { get; set; }

    public virtual DbSet<MetalInvestment> MetalInvestments { get; set; }

    public virtual DbSet<MutualFundInvestment> MutualFundInvestments { get; set; }

    public virtual DbSet<PensionInvestment> PensionInvestments { get; set; }

    public virtual DbSet<RealEstateInvestment> RealEstateInvestments { get; set; }

    public virtual DbSet<RecurringExpense> RecurringExpenses { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserFinancialProfile> UserFinancialProfiles { get; set; }

    public virtual DbSet<UserInformation> UserInformations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        if (modelBuilder == null)
            return;
        modelBuilder.Entity<BankInstruction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__bankInst__3213E83F5F66A9B0");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AccountType).IsFixedLength();
            entity.Property(e => e.Ifsc).IsFixedLength();
        });

        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.ExpenseId).HasName("PK__Bill__1445CFD3CA35EFCE");

            entity.Property(e => e.ExpenseId).ValueGeneratedNever();
            entity.Property(e => e.LateFeeApplicable).HasDefaultValue(false);
        });

        modelBuilder.Entity<Card>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__card__3213E83F8431F5FF");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CardNumer).IsFixedLength();
            entity.Property(e => e.CardType).IsFixedLength();
        });

        modelBuilder.Entity<CreditCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__creditCa__3213E83F967762C4");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<DebitCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__debitCar__3213E83FA7E280C1");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<EquityInvestment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__equityIn__3213E83FA271BDA1");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Expense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__expenses__3214EC271A13BD72");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ExpenseSplit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__expenseS__3213E83F2F80306C");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Family>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__family__3213E83FFAE9F35C");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<FamilyMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__family_m__3213E83F71B24B4A");
        });

        modelBuilder.Entity<FixedDepositInvestment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__fixedDep__3213E83F6B9C52BE");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<InsuranceInvestment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__insuranc__3213E83FC6FA9E61");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Investment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__investme__3213E83FBADADF0F");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.InvestmentType).IsFixedLength();
        });

        modelBuilder.Entity<InvestmentTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__investme__3213E83F535B62EA");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<MetalInvestment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__metalInv__3213E83FFDC61360");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<MutualFundInvestment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mutualFu__3213E83F67B807EA");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PensionInvestment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pensionI__3213E83F7F8E5336");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RealEstateInvestment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__realEsta__3213E83F4A82F333");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RecurringExpense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__recurrin__3214EC271297772A");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tags__3213E83FA691547D");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3213E83FDF27B095");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Gender).IsFixedLength();
        });

        modelBuilder.Entity<UserFinancialProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user_fin__3213E83F547F1334");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<UserInformation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user_inf__3213E83F21CC5E3D");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Aadhar).IsFixedLength();
            entity.Property(e => e.Pan).IsFixedLength();
        });

    }
}
