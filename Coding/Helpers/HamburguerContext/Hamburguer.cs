namespace Coding.Helpers.HamburguerContext;

public class Hamburguer
{
    private Vegetable _vegetable;
    private Meat _meat;

    public Hamburguer(Vegetable vegetable, Meat meat)
    {
        _vegetable = vegetable;
        _meat = meat;
    }

    public decimal GetPrice()
    {
        var total;

        if (_vegetable != null) total += 10;
        if (_meat != null) total += 20;

        var tip = 5;
        total += tip;

        return total;
    }

    public void Process()
    {
        if (_vegetable == null) throw new Exception();
        if (_meat == null) throw new Exception();

        // process the hamburguer
    }
}