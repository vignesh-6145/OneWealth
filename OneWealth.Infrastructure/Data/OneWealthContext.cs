using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OneWealth.Infrastructure.DataModels;

namespace OneWealth.Infrastructure.Data;

public class OneWealthContext : DbContext
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
        if(modelBuilder is null)
            return;
        modelBuilder.Entity<BankInstruction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__bankInst__3213E83FB883DF18");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AccountType).IsFixedLength();
            entity.Property(e => e.Ifsc).IsFixedLength();
        });

        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.ExpenseId).HasName("PK__Bill__1445CFD33BE5DDD5");

            entity.Property(e => e.ExpenseId).ValueGeneratedNever();
            entity.Property(e => e.LateFeeApplicable).HasDefaultValue(false);
        });

        modelBuilder.Entity<Card>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__card__3213E83FE3FD9674");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CardNumer).IsFixedLength();
            entity.Property(e => e.CardType).IsFixedLength();
        });

        modelBuilder.Entity<CreditCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__creditCa__3213E83FECA16D6D");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<DebitCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__debitCar__3213E83F888BC868");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<EquityInvestment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__equityIn__3213E83F22837F6C");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Expense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__expenses__3214EC275D326607");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ExpenseSplit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__expenseS__3213E83FA8022CA5");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Family>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__family__3213E83FCBCD6C2F");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<FamilyMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__family_m__3213E83FAB96EECF");
        });

        modelBuilder.Entity<FixedDepositInvestment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__fixedDep__3213E83F4C8FA469");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<InsuranceInvestment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__insuranc__3213E83FA6D2C28E");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Investment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__investme__3213E83F622E0E48");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.InvestmentType).IsFixedLength();
        });

        modelBuilder.Entity<InvestmentTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__investme__3213E83FF9733E5A");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<MetalInvestment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__metalInv__3213E83F126E58A6");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<MutualFundInvestment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mutualFu__3213E83FFF56EE09");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PensionInvestment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pensionI__3213E83F1AE2E37F");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RealEstateInvestment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__realEsta__3213E83FAFA545D2");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RecurringExpense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__recurrin__3214EC27E0DC26E5");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tags__3213E83FA5C59FD9");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3213E83F7CCF9DF5");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Gender).IsFixedLength();
        });

        modelBuilder.Entity<UserFinancialProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user_fin__3213E83F3CF111C7");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<UserInformation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user_inf__3213E83F4D970B2A");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Aadhar).IsFixedLength();
            entity.Property(e => e.Pan).IsFixedLength();
        });

    }

}
