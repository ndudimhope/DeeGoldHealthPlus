using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeeGoldHealthPlus.models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
