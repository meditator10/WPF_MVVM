using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMdemo.Commands;

namespace MVVMdemo.ViewModels
{
    class MainWindowViewModel:NotificationObject
    {
        // 三个数据属性
        private double input1;

        public double Input1
        {
            get { return input1; }
            set { 
                input1 = value;
                // 当propertyName改变，调用
                this.RaisePropertyChanged("Input1");
            }
        }

        private double input2;

        public double Input2
        {
            get { return input2; }
            set { 
                input2 = value;
                this.RaisePropertyChanged("Input2");
            }
        }

        private double result;

        public double Result
        {
            get { return result; }
            set { 
                result = value;
                this.RaisePropertyChanged("Result");
            }
        }

        //两个命令属性（含有事件的类）
        // 当点击UI上的add按钮，Binding会链接到AddCommand，这是一个包含事件的类,让响应者可以获取订阅信息
        // 在构造器中，把相加功能委托给add方法
        public DelegateCommand AddCommand { get; set; }
        public DelegateCommand SaveCommand { get; set; }


        public MainWindowViewModel()
        {
            this.AddCommand = new DelegateCommand();
            this.AddCommand.ExecuteAction = new Action<object>(this.Add);
        }

        // 供ExecuteAction委托使用，所以必须要包含一个object参数(虽然这里没用到)
        private void Add(object m)
        {
            this.Result = this.Input1 + this.Input2;
        }
    }
}
