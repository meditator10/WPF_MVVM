using System;
using System.Windows.Input;

namespace BabyResturant.Client.Commands
{
    class DelegateCommand : ICommand
    {
        // 声明两个委托类型的属性
        public Action<object> ExecuteAction { get; set; }
        public Func<object, bool> CanExecuteFunc { get; set; }

        // 继承自ICommand接口
        public event EventHandler CanExecuteChanged;

        // 判断命令是否可用
        public bool CanExecute(object parameter)
        {
            return this.CanExecuteFunc?.Invoke(parameter) ?? true;
        }

        // 命令的具体执行
        public void Execute(object parameter)
        {
            // 通知UI哪个属性的值发生了变化
            // 使用了委托，命令的具体执行方法放在ViewModel中实现
            this.ExecuteAction?.Invoke(parameter);
        }

        // 没用上
        public void RaiseCanExecuteChange()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}
