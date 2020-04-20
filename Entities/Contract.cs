﻿using System;
using System.Collections.Generic;

namespace EFixInterface.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public List<Installment> installments = new List<Installment>();

        public Contract(int number, DateTime date, double value)
        {
            Number = number;
            Date = date;
            Value = value;
        }

        public void addInstallment(Installment installment)
        {
            installments.Add(installment);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
