using System;
using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        private IList<Payment> _payments;

        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();
        }

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active {get; private set;}

        public IReadOnlyCollection<Payment> Payments {get {return this._payments.ToArray();}}

        public void AddPayments(Payment payment)
        {
            this._payments.Add(payment);
        }

        public void Activate()
        {
            this.Active = true;
            this.LastUpdateDate = DateTime.Now;
        }

        public void Deactivate()
        {
            this.Active = false;
            this.LastUpdateDate = DateTime.Now;
        }        
            
    }
}