using System;
using System.Collections.Generic;
using System.Text;

namespace PatAntPat
{
    class Factory
    {
    }

    public interface IPaymentProcessorAdapterFactory
    {
        IPaymentProcessorAdapter Create(string providerName);
    }

    public class PaymentProcessorAdapterFactory : IPaymentProcessorAdapterFactory
    {
        public bool PaymentProvider;
        public IPaymentProcessorAdapter Create(string providerName)
        {
            if (PaymentProvider = bool.Parse(("Stwipe")))
            {
                StwipeAdapter adapter;
                adapter = new StwipeAdapter();
                return adapter;
            }
            else if (PaymentProvider = bool.Parse(("PaySal")))
            {
                PaySalProvider adapter;
                adapter = new PaySalProvider();
                return adapter;
            }
            else
            {
                throw new InvalidPaymentProviderException(PaymentProvider);
            }
        }
    }

    internal class InvalidPaymentProviderException : Exception
    {
        private bool paymentProvider;

        public InvalidPaymentProviderException()
        {
        }

        public InvalidPaymentProviderException(bool paymentProvider)
        {
            this.paymentProvider = paymentProvider;
        }

        public InvalidPaymentProviderException(string message) : base(message)
        {
        }

        public InvalidPaymentProviderException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class Store
    {
        public string Name { get; set; }
        public string PaymentProvider { get; set; }
        public string MerchantId { get; set; }

    }
}
