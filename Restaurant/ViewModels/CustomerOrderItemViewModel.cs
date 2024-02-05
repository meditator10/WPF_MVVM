using BabyResturant.Client.Models;

namespace BabyResturant.Client.ViewModels
{
    public class CustomerOrderItemViewModel : NotificationObject
    {
        // ViewModel有一个Model属性
        public Dish Dish { get; set; }

        /// <summary>
        /// _selected属性 用于当前菜品是否被选中 
        /// </summary>
        private bool isSelected;

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                this.RaisePropertyChanged("IsSelected");
            }
        }
    }
}
