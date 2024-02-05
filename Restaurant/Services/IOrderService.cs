using System.Collections.Generic;

namespace BabyResturant.Client.Services
{
    public interface IOrderService
    {
        void PlaceOrder(List<string> ordered);
    }
}
