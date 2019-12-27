using LoanCalculator.Core.DataInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanCalculator.Core.Domain
{
    public class LoanSizeLoanApprovalRule : ILoanQualificationRule
    {


        public const String RULE_NAME = "Loan Size";

        public string RuleName { get => RULE_NAME; }

        public bool CheckLoanApprovalRule(LoanApplication application)
        {
            var loanAmount = application.LoanAmount;

            switch (loanAmount)
            {
                case double n when (n < 5_00_000):
                    // We don't issue loans less than ₹5,00,000
                    return false;
                case double n when (n >= 5_00_000 && n < 1_00_00_000):
                    // Loans from ₹5,00,000 to ₹1,00,00,000 are OK
                    return true;
                case double n when (n > 1_00_00_000):
                    // Do not issue loans over ₹1,00,00,000
                    return false;
                default:
                    return false;
            }
        }


    }
}
