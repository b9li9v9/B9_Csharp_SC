﻿NuGet	
	1.Install-Package Microsoft.EntityFrameworkCore.SqlServer
	2.Install-Package Microsoft.EntityFrameworkCore.Tools
配置
	1.实体类
	2.实体配置类 继承IEntityTypeConfiguration<实体类> 
	3.dbctx类   继承DbContext类 -> use db,set table
Migration
	1.Add-Migration Init 生成DB配置代码 
	2.Update-database    执行DB配置代码 单向迁移 


主外键关联、字段约束的写法还是很麻烦，
需要改动主键的表 外键的表 以及DBCTX

EFCore有个约定大于配置的特点 
EFCore的批量操作需要仔细检验过程
最好用FLunet API -> https://blog.51cto.com/u_15127644/2756675
Id默认为主键

"关系" 这个地方没透，先放一放
一对多关系：一个表中的多行数据关联到另一个表中的一行数据。例如，订单表和客户表之间的关系，一个客户可以有多个订单，每个订单对应一个客户。
多对多关系：两个表之间相互关联，每个表中的一行数据可以关联到另一个表中的多行数据。例如，学生和课程之间的关系，一个学生可以选择多门课程，而一门课程也可以被多个学生选择。
层次关系：数据之间存在层级关系，需要通过外键来连接父子关系。例如，部门表中的每个部门可能有一个上级部门，通过外键来指示上级部门。
