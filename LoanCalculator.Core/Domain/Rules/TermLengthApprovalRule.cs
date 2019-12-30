using LoanCalculator.Core.DataInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanCalculator.Core.Domain
{
    public class TermLengthApprovalRule : ILoanQualificationRule
    {
        public const String RULE_NAME = "Term Length";

        public string RuleName { get => RULE_NAME; }

        public bool CheckLoanApprovalRule(LoanApplication application)
        {
            if (application.LoanAmount < 40_00_000)
            {
                // Smaller loans (upto ₹40,00,000) must have shorter terms
                return application.Term.Years <= 20;
            }
            else
            {
                // Large loans (equal to and above ₹40,00,000) must have longer terms
                return application.Term.Years >= 15;
            }
        }


    }
}
