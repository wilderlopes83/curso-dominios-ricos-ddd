using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private IList<Subscription> _subscriptions;

        public Student(Name name, Document document, string email, string address)
        {
            Name = name;
            Document = document;
            Email = email;
            Address = address;
            _subscriptions = new List<Subscription>();
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public string Email { get; private set; }
        public string Address {get; private set;}
        public IReadOnlyCollection<Subscription> Subscriptions {get{return this._subscriptions.ToArray();}}        

        public void AddSubscription(Subscription subscription)
        {
            //se já tiver uma assinatura ativa, cancela

            //cancela todas as outras assinaturas e coloca esta como principal
            foreach (var sub in this.Subscriptions)
            {
                sub.Deactivate();
            }

            this._subscriptions.Add(subscription);
        }
    }
    
 }
