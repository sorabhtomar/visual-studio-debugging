﻿// <auto-generated />
using System;
using LoanCalculator.Data.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoanCalculator.Data.EFCore.Migrations
{
    [DbContext(typeof(LoanCalculatorContext))]
    partial class LoanCalculatorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LoanCalculator.Core.Domain.LoanApplicationResult", b =>
                {
                    b.Property<int>("ResultId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnnualIncome");

                    b.Property<string>("ApplicantType");

                    b.Property<bool>("Approved");

                    b.Property<int>("CreditScore");

                    b.Property<string>("DenialReason");

                    b.Property<string>("FirstName");

                    b.Property<double?>("InterestRate");

                    b.Property<string>("LastName");

                    b.Property<double>("LoanAmount");

                    b.Property<int>("LoanTerm");

                    b.Property<double?>("MonthlyPayment");

                    b.HasKey("ResultId");

                    b.ToTable("LoanApplicationResults");

                    b.HasData(
                        new
                        {
                            ResultId = 1,
                            AnnualIncome = 75000,
                            ApplicantType = "Standard",
                            Approved = true,
                            CreditScore = 790,
                            FirstName = "John",
                            InterestRate = 0.085000000000000006,
                            LastName = "Smith",
                            LoanAmount = 125000.0,
                            LoanTerm = 30,
                            MonthlyPayment = 769.64999999999998
                        },
                        new
                        {
                            ResultId = 2,
                            AnnualIncome = 60000,
                            ApplicantType = "Standard",
                            Approved = true,
                            CreditScore = 680,
                            FirstName = "Mary",
                            InterestRate = 0.074999999999999997,
                            LastName = "Jones",
                            LoanAmount = 135000.0,
                            LoanTerm = 30,
                            MonthlyPayment = 934.94000000000005
                        },
                        new
                        {
                            ResultId = 4,
                            AnnualIncome = 125000,
                            ApplicantType = "Standard",
                            Approved = true,
                            CreditScore = 880,
                            FirstName = "Sally",
                            InterestRate = 0.050000000000000003,
                            LastName = "Johnson",
                            LoanAmount = 250000.0,
                            LoanTerm = 20,
                            MonthlyPayment = 1684.6099999999999
                        },
                        new
                        {
                            ResultId = 5,
                            AnnualIncome = 75000,
                            ApplicantType = "Standard",
                            Approved = true,
                            CreditScore = 790,
                            FirstName = "John",
                            InterestRate = 0.074999999999999997,
                            LastName = "Test",
                            LoanAmount = 125000.0,
                            LoanTerm = 30,
                            MonthlyPayment = 769.64999999999998
                        },
                        new
                        {
                            ResultId = 6,
                            AnnualIncome = 60000,
                            ApplicantType = "Standard",
                            Approved = true,
                            CreditScore = 680,
                            FirstName = "Jeff",
                            InterestRate = 0.0625,
                            LastName = "Pral",
                            LoanAmount = 135000.0,
                            LoanTerm = 10,
                            MonthlyPayment = 934.94000000000005
                        },
                        new
                        {
                            ResultId = 7,
                            AnnualIncome = 100000,
                            ApplicantType = "Standard",
                            Approved = false,
                            CreditScore = 460,
                            DenialReason = "Credit Score",
                            FirstName = "Steve",
                            LastName = "Sun",
                            LoanAmount = 0.0,
                            LoanTerm = 30
                        },
                        new
                        {
                            ResultId = 8,
                            AnnualIncome = 125000,
                            ApplicantType = "Premiere",
                            Approved = true,
                            CreditScore = 880,
                            FirstName = "Alan",
                            InterestRate = 0.17499999999999999,
                            LastName = "Roll",
                            LoanAmount = 250000.0,
                            LoanTerm = 20,
                            MonthlyPayment = 1684.6099999999999
                        },
                        new
                        {
                            ResultId = 9,
                            AnnualIncome = 75000,
                            ApplicantType = "Premiere",
                            Approved = true,
                            CreditScore = 790,
                            FirstName = "Bob",
                            InterestRate = 0.14999999999999999,
                            LastName = "Stevens",
                            LoanAmount = 25000.0,
                            LoanTerm = 10,
                            MonthlyPayment = 769.64999999999998
                        },
                        new
                        {
                            ResultId = 3,
                            AnnualIncome = 100000,
                            ApplicantType = "Standard",
                            Approved = false,
                            CreditScore = 460,
                            DenialReason = "Credit Score",
                            FirstName = "Andy",
                            LastName = "Anderson",
                            LoanAmount = 0.0,
                            LoanTerm = 30
                        },
                        new
                        {
                            ResultId = 10,
                            AnnualIncome = 60000,
                            ApplicantType = "Standard",
                            Approved = true,
                            CreditScore = 680,
                            FirstName = "Phil",
                            InterestRate = 0.074999999999999997,
                            LastName = "Tell",
                            LoanAmount = 135000.0,
                            LoanTerm = 20,
                            MonthlyPayment = 934.94000000000005
                        },
                        new
                        {
                            ResultId = 11,
                            AnnualIncome = 100000,
                            ApplicantType = "Standard",
                            Approved = false,
                            CreditScore = 406,
                            DenialReason = "Credit Score",
                            FirstName = "Joel",
                            LastName = "Tess",
                            LoanAmount = 0.0,
                            LoanTerm = 30
                        },
                        new
                        {
                            ResultId = 12,
                            AnnualIncome = 125000,
                            ApplicantType = "Standard",
                            Approved = true,
                            CreditScore = 880,
                            FirstName = "Bob",
                            InterestRate = 0.050000000000000003,
                            LastName = "Test",
                            LoanAmount = 250000.0,
                            LoanTerm = 20,
                            MonthlyPayment = 1684.6099999999999
                        });
                });

            modelBuilder.Entity("LoanCalculator.Core.Domain.LoanRate", b =>
                {
                    b.Property<int>("LoanRateId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("InterestRate");

                    b.Property<int>("LoanTypeId");

                    b.Property<int>("LowerCreditScore");

                    b.Property<int>("UpperCreditScore");

                    b.HasKey("LoanRateId");

                    b.HasIndex("LoanTypeId");

                    b.ToTable("LoanRates");

                    b.HasData(
                        new
                        {
                            LoanRateId = 1,
                            InterestRate = 0.10000000000000001,
                            LoanTypeId = 2,
                            LowerCreditScore = 300,
                            UpperCreditScore = 499
                        },
                        new
                        {
                            LoanRateId = 2,
                            InterestRate = 0.085000000000000006,
                            LoanTypeId = 1,
                            LowerCreditScore = 500,
                            UpperCreditScore = 599
                        },
                        new
                        {
                            LoanRateId = 3,
                            InterestRate = 0.074999999999999997,
                            LoanTypeId = 1,
                            LowerCreditScore = 600,
                            UpperCreditScore = 699
                        },
                        new
                        {
                            LoanRateId = 4,
                            InterestRate = 0.0625,
                            LoanTypeId = 2,
                            LowerCreditScore = 700,
                            UpperCreditScore = 799
                        },
                        new
                        {
                            LoanRateId = 5,
                            InterestRate = 0.050000000000000003,
                            LoanTypeId = 2,
                            LowerCreditScore = 800,
                            UpperCreditScore = 900
                        });
                });

            modelBuilder.Entity("LoanCalculator.Core.Domain.LoanType", b =>
                {
                    b.Property<int>("LoanTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoanTypeName");

                    b.HasKey("LoanTypeId");

                    b.ToTable("LoanTypes");

                    b.HasData(
                        new
                        {
                            LoanTypeId = 1,
                            LoanTypeName = "Car Loan"
                        },
                        new
                        {
                            LoanTypeId = 2,
                            LoanTypeName = "Education Loan"
                        },
                        new
                        {
                            LoanTypeId = 3,
                            LoanTypeName = "Home Loan"
                        },
                        new
                        {
                            LoanTypeId = 4,
                            LoanTypeName = "Personal Loan"
                        },
                        new
                        {
                            LoanTypeId = 5,
                            LoanTypeName = "Business Loan"
                        },
                        new
                        {
                            LoanTypeId = 6,
                            LoanTypeName = "Gold Loan"
                        });
                });

            modelBuilder.Entity("LoanCalculator.Core.Domain.LoanRate", b =>
                {
                    b.HasOne("LoanCalculator.Core.Domain.LoanType", "LoanType")
                        .WithMany("Rates")
                        .HasForeignKey("LoanTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
