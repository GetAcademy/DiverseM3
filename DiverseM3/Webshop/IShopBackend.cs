using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiverseM3.Webshop
{
    interface IShopBackend
    {
        bool Order(ShoppingCart shoppingCart);
    }
}
