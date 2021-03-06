﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CreditMarket.Models
{
    public class ApprovedOrder: Base
    {
        public int? LoanPeriod { get; set; }

        public string UnionName { get; set; }

        public double? Amount { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string FathersName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(12)]
        public string PhoneNumber { get; set; }

        public long? CardNumber { get; set; }

        
        public long? INN { get; set; }

        [StringLength(8)]
        public string PassportNumber { get; set; }

        [StringLength(120)]
        public string PassportGivenByWhom { get; set; }

        public DateTime? PassportGivenDate { get; set; }

        public DateTime ApprovedDate { get; set; }

        public string OrderStatus { get; set; }

        public string FullName
        {
            get
            {
                return LastName + " " + FirstName + " " + FathersName;
            }
        }
    }
}