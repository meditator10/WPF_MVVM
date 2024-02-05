using BabyResturant.Client.Models;
using System.Collections.Generic;

namespace BabyResturant.Client.Services
{
    public interface IDataService
    {
        // 抽象方法，用于返回菜品
        List<Dish> FindAllDishes();
    }
}
