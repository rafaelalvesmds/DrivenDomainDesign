using System;

namespace PaymentContext.Domain.Entites
{
    public abstract class Payment
    {
        public Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string adress, string document, string owner, string email)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Adress = adress;
            Document = document;
            Owner = owner;
            Email = email;
        }

        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string Adress { get; private set; }
        public string Document { get; private set; }
        public string Owner { get; private set; }
        public string Email { get; private set; }
    }
}