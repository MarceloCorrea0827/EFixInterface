using System;
using EFixInterface.Entities;
using EFixInterface.Interfaces;

namespace EFixInterface.Services
{
    class ProcessContract
    {
        public int Quotes { get; set; }
        private IPaymentInstallment _paymentInstallment; // Interface

        public ProcessContract(int quotes, IPaymentInstallment paymentInstallment)
        {
            Quotes = quotes;
            _paymentInstallment = paymentInstallment;
        }

        public void processInstallments(Contract contract)
        {
            DateTime date = contract.Date;
            double amount = (contract.Amount / Quotes);

            for (int quote=1; quote<=Quotes; quote++)
            {
                if (quote > 1)
                {
                    date = date.AddDays(30);
                }

                amount += _paymentInstallment.Tax(amount, quote);
                amount += _paymentInstallment.SimpleInterest(amount);

                contract.addInstallment(new Installment(date, amount));
                amount = (contract.Amount / Quotes);
            }
        }
    }
}