# injection_Decorate

لتعديل تبعية محقونه dependency-injection

Installation
قم بتنصيبها على البرنامج
Install the Scrutor NuGet Package.

Package Manager Console
```
Install-Package Scrutor
```
.NET Core CLI
```
dotnet add package Scrutor
```

//للإضافة السابقة
builder.Services.AddSingleton<ITest, Test1>();
//حذف التبعية المحقونه سابقاً
builder.Services.Decorate<ITest, Test1>();
// إضافة تبعية محقونه الجديدة
builder.Services.AddScoped<ITest, Test2>();
