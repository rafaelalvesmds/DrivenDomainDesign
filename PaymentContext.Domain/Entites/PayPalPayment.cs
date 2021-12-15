using System;

namespace PaymentContext.Domain.Entites
{

    public class PayPalPayment : Payment

    {
        public string TransactionCode { get; private set; }

        public PayPalPayment(string transactionCode, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string adress, string document, string owner, string email) : base(paidDate, expireDate, total, totalPaid, adress, document, owner, email)
        {
            TransactionCode = transactionCode;
        }

    }
}