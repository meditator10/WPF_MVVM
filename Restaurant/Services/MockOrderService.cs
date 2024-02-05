using System;
using System.Collections.Generic;
using System.IO;

namespace BabyResturant.Client.Services
{
    public class MockOrderService : IOrderService
    {
        // 账单保存路径
        public string MockOutputFileName { get; set; } = @"MyOrder.txt";

        /// <summary>
        /// 抽象方法输出 点餐账单打印到txt日志中
        /// </summary>
        public void PlaceOrder(List<string> ordered)
        {
            string[] array = ordered.ToArray();
            string path = Path.Combine(Environment.CurrentDirectory, MockOutputFileName);
            File.WriteAllLines(path, array);
        }
    }
}
