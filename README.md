# WPF_MVVM
刘铁猛 深入浅出WPF的MVVM练习项目
## 《深入浅出WPF》系列教程代码
> [B站视频链接](https://www.bilibili.com/video/BV1ht411e7Fe?p=7)  
> [作者Youtube主页](https://www.youtube.com/user/waspec/videos)

## MVVM简单介绍
### 1、为什么要使用MVVM模式
团队层面: 统一思维方式和实现方法  
架构层面: 稳定，解耦，富有禅意  
代码层面 : 可读，可测，可替换 
### 2、什么是Model
现实世界中对象的抽象结果
### 3、什么是View和ViewModel
View = UI（文不如表，表不如图）（命令行界面不如普通的控件界面，普通的控件UI不如带图形界面的UI）  
ViewModel = Model for View (带逻辑的view)  
ViewModel与View的沟通

传递数据一一数据属性  
传递操作一一命令属性  
### 4、一定要使用MVVM吗
答案是否定的，首先一个项目/工程要上设计框架那一定是有一定规模的（避免过度设计）
其次MVVM比较适用于企业级程序，比如文件管理系统、点餐系统、邮件系统等

## 演示效果
### 1、MVVM demo
![](/MVVM demo/demo.png)

### 2、Restaurant
![](/Restaurant/demo.png)