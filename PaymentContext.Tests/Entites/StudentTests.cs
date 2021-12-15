using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entites;

namespace paymentcontext.tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var student = new Student("Rafael", "Souza", "mg4545454", "rafael@teste.com");

            var subscription = new Subscription(null);
            student.AddSubscription(subscription);
        }
    }
}
