namespace DiverseM3.Webshop
{
    interface IPayment
    {
        bool Pay(decimal amount);
    }
}
