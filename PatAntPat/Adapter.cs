using System;

namespace PatAntPat
{
    class Adapter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class StwipeProvider
    {
        public StwipeProvider(string merchantKey) { }

        public bool Pay(string cardNumber, string expiration, decimal amount)
        {
            return true;
        }
    }

    public class PaySalProvider
    {
        public void ProcessPayment(string merchantId, CreditCardDetails cardInfo, decimal amount) { }
    }

    public interface IPaymentProcessorAdapter
    {
        bool ProcessPayment(string merchantId, string cardNumber, string expiration, decimal amount);
    }

    public class StwipeAdapter : IPaymentProcessorAdapter
    {
        public bool ProcessPayment(string merchantId, string cardNumber, string expiration, decimal amount)
        {
            var provider = new PaySalProvider();
            try
            {
                var cardInfo = new CreditCardDetails(cardNumber, expiration);
                provider.ProcessPayment(merchantId, cardInfo, amount);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public class CreditCardDetails
    {
        string cardNumber;
        string expiration;

        public CreditCardDetails(string cardNumber, string expiration)
        {

        }
    }
}