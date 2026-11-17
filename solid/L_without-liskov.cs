// SIN LISKOV

var credit = new CreditCardPayment();
var paypal = new PayPalPayment();

var processor = new PaymentProcessor();

processor.Process(credit);
processor.Process(paypal);

public class Payment
{
    public virtual void ValidateCardDetails()
    {
        // Se valida la información de la tarjeta de crédito
    }

    public virtual void ProcessPayment()
    {
        // Lógica para procesar el pago
    }
}

public class CreditCardPayment : Payment
{
    public override void ValidateCardDetails()
    {
        Console.WriteLine("Se valida la información de la tarjeta de crédito.");
    }

    public override void ProcessPayment()
    {
        Console.WriteLine("Se procesa el pago con tarjeta de crédito.");
    }
}

public class PayPalPayment : Payment
{
    public override void ValidateCardDetails()
    {
        throw new NotSupportedException("PayPal no tiene datos de tarjeta para validar.");
    }

    public override void ProcessPayment()
    {
        Console.WriteLine("Se procesa el pago con PayPal.");
    }
}


public class PaymentProcessor
{
    public void Process(Payment payment)
    {
        payment.ValidateCardDetails();
        payment.ProcessPayment();
    }
}
