using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMdemo.Commands
{
    class DelegateCommand : ICommand
    {
        // 声明两个委托类型的字段
        public Action<object> ExecuteAction;
        public Func<object, bool> CanExecuteFunc;

        // 继承自ICommand接口
        public event EventHandler CanExecuteChanged;

        // 判断命令是否可用
        public bool CanExecute(object parameter)
        {
            return this.CanExecuteFunc?.Invoke(parameter) ?? true;
        }

        // 事件处理器：命令的具体执行
        public void Execute(object parameter)
        {
            this.ExecuteAction?.Invoke(parameter);
        }

        // 没用上
        public void RaiseCanExecuteChange()
        {
            if(CanExecuteChanged!=null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}
