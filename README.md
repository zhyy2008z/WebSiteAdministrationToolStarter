Web Site Administration Tool Starter
===========================
网站管理员工具启动器
--------------

###功能

**`用来启动Web Site Administration Tool。`** The ASP.NET Web Site Administration Tool allows you to view and manage your Web site configuration through a simple Web interface。[详细](http://msdn.microsoft.com/en-us/library/ms228053(v=vs.100).aspx "详细")

###为什么要开发本工具？
>随着vs2012及vs2013的发布，我们发现微软把【Web Site Administration Tool】的入口从VS删除了，如果我们还想用这个工具怎么办？快使用我的网站管理员工具启动器吧！

###使用方法
>* 方式一：双击直接运行。
>* 方式二：将本工具添加到vs的外部工具（External Tools）中，设置参数（Arguments）为：$(ProjectDir) $(TargetName) ，以后就可以直接从外部工具列表中使用了。注意：当前选中的项目必须为**Web项目**啊！
