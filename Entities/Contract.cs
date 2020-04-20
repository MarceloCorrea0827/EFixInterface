using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace EFixInterface.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public List<Installment> installments = new List<Installment>();

        public Contract(int number, DateTime date, double amount)
        {
            Number = number;
            Date = date;
            Amount = amount;
        }

        public void addInstallment(Installment installment)
        {
            installments.Add(installment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Installment installment in installments) {
                sb.Append(installment.Date.ToString("dd/MM/yyyy"));
                sb.Append(" - ");
                sb.AppendLine(installment.Amount.ToString("F2",CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }
    }
}