namespace DiverseM3.Webshop
{
    class ShopService
    {
        private readonly IShopBackend _shopBackend;
        private readonly IPayment _payment;

        public ShopService(IPayment payment, IShopBackend shopBackend)
        {
            _payment = payment;
            _shopBackend = shopBackend;
        }

        bool Buy(ShoppingCart cart)
        {
            var amount = cart.Amount;
            var isSuccess = _payment.Pay(amount);
            if (!isSuccess) return false;
            return _shopBackend.Order(cart);
        }
    }
}
