namespace Coding.Helpers.PaymentContext;

public class Payment
{
    private PaymentMethod _paymentMethod = new PaymentMethod();
    private decimal _totalAmount;

    public Payment(decimal totalAmount, PaymentMethod paymentMethod)
    {
        _paymentMethod = paymentMethod;
        _totalAmount = totalAmount;
    }

    public decimal GetTotalWithInterest()
    {
        if _paymentMethod == PaymentMethod.Card
        {
            return _totalAmount + _totalAmount * 0.1;
        }

        return _totalAmount;
    }
}