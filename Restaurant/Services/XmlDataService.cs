using BabyResturant.Client.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace BabyResturant.Client.Services
{
    public class XmlDataService : IDataService
    {
        /// <summary>
        /// 抽象方法，获取xml文件的菜品
        /// </summary>
        public List<Dish> FindAllDishes()
        {
            List<Dish> list = new List<Dish>();

            // Linq for Xml
            // 获取相对路径
            string dataDir = @"Data";
            string dataFile = @"Data.xml";
            string xmlFilePath = dataDir + @"\" + dataFile;
            // 获取绝对路径
            string xmlFileFullPath = Path.Combine(Environment.CurrentDirectory, xmlFilePath);
            // 加载文件
            XDocument xDoc = XDocument.Load(xmlFileFullPath);

            var dishes = xDoc.Descendants("Dish");
            foreach (var d in dishes)
            {
                Dish dish = new Dish();
                dish.Name = d.Element("Name").Value;
                dish.Category = d.Element("Category").Value;
                dish.Description = d.Element("Description").Value;
                dish.Score = d.Element("Score").Value;

                list.Add(dish);
            }
            return list;
        }
    }
}
