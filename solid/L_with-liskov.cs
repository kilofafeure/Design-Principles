// CON LISKOV

var credit = new CreditCardPayment();
var paypal = new PayPalPayment();

var processor = new PaymentProcessor();

processor.Process(credit);
processor.Process(paypal);


var cardProcessor = new CardPaymentProcessor();
cardProcessor.Process(credit);


public class Payment
{
    public virtual void ProcessPayment()
    {
        // Lógica para procesar el pago
    }
}

public class CardPayment : Payment
{
    public virtual void ValidateCardDetails()
    {
        Console.WriteLine("Se valida la información de la tarjeta de crédito.");
    }
}


public class CreditCardPayment : CardPayment
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
    public override void ProcessPayment()
    {
        Console.WriteLine("Se procesa el pago con PayPal.");
    }
}


public class PaymentProcessor
{
    public void Process(Payment payment)
    {
        payment.ProcessPayment();
    }
}

public class CardPaymentProcessor
{
    public void Process(CardPayment payment)
    {
        payment.ValidateCardDetails();
        payment.ProcessPayment();
    }
}

