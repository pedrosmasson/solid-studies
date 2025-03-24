using Coding.Helpers.HamburguerContext;
using Coding.Helpers.PaymentContext;

namespace Coding.SingleResponsability;

public class Bad
{
    public void GetHamburguer()
    {
        var lettuce = new Vegetable();
        var cheapestMeatAvailable = new Meat();
        var hamburguer = new Hamburguer(lettuce, cheapestMeatAvailable);

        try
        {
            hamburguer.Process();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    
        var payment = new Payment(PaymentMethod.Card, hamburguer.GetPrice());

        payment.GetTotalWithInterest();

        // proceeds to add more code, disrespecting the single responsability principle
    }
}