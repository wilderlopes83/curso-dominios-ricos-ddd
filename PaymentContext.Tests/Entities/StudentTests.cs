using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var subscription = new Subscription(null);
            var student = new Student("Wilder", "Lopes", "123141", "wilderlopes83@gmail.com", "Rua x");
            //student.Subscriptions.Add(subscription);
            student.AddSubscription(subscription);
            //student.FirstName = "";
        }
    }
}