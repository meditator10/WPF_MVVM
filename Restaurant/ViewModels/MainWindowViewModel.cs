using BabyResturant.Client.Models;
using BabyResturant.Client.Services;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyResturant.Client.ViewModels
{
    /// <summary>
    /// view model
    /// </summary>
    public class MainWindowViewModel : NotificationObject
    {
        // 两个命令属性
        public DelegateCommand PlaceOrderCommand { get; set; }
        public DelegateCommand SelectMenuItemCommand { get; set; }

        // 三个数据属性
        private int count;
        public int Count
        {
            get { return count; }
            set {
                count = value;
                this.RaisePropertyChanged("Count");
            }
        }


        private Restaurant restaurant;
        public Restaurant Restaurant
        {
            get { return restaurant; }
            set {
                restaurant = value;
                this.RaisePropertyChanged("Restaurant");
            }
        }


        private List<CustomerOrderItemViewModel> dishMenu;
        public List<CustomerOrderItemViewModel> DishMenu
        {
            get { return dishMenu; }
            set {
                dishMenu = value;
                this.RaisePropertyChanged("DishMenu");
            }
        }
        
        
        public MainWindowViewModel()
        {
            loadRestraunt();
            loadDishMenu();
            PlaceOrderCommand = new DelegateCommand(PlaceOrderCommandExcute);
            SelectMenuItemCommand = new DelegateCommand(SelectMenuItemCommandExcute);
        }

        private void SelectMenuItemCommandExcute()
        {
            this.Count = this.DishMenu.Count(m => m.IsSelected == true);
        }

        private void PlaceOrderCommandExcute()
        {
            var selectedDishes = this.DishMenu.Where(m => m.IsSelected == true).Select(m => m.Dish.Name).ToList();
            IOrderService orderService = new MockOrderService();
            orderService.PlaceOrder(selectedDishes);
            System.Windows.MessageBox.Show("下单成功！");
        }

        private void loadDishMenu()
        {
            XmlDataService xmlDataServices = new XmlDataService();
            var dishes = xmlDataServices.FindAllDishes();
            this.DishMenu = new List<CustomerOrderItemViewModel>();
            dishes.ForEach(m => this.DishMenu.Add(new CustomerOrderItemViewModel() { Dish = m }));
        }

        private void loadRestraunt()
        {
            this.Restaurant = new Restaurant();
            this.Restaurant.Name = "宝宝披萨";
            this.Restaurant.Address = "万达广场店";
            this.Restaurant.PhoneNumber = "123-456-789";
        }
    }
}
