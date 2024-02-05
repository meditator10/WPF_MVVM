# 两个重要的基类
## 1、NotificationObject 	数据属性
## 2、DelegateCommand 		命令属性

# View和ViewModel的交互


   在更新UI数据上，WinForm会使用控件的名字来操作控件的属性，而WPF中通常是通过数据绑定来更新UI；
   在响应用户操作上，WinForm是通过控件的事件来处理，而WPF可以使用命令绑定的方式来处理，耦合度将降低。