# README
数据库课程设计--书店书刊出租和零售系统



## 使用说明

- 使用前需导入`Book\BookStore\sqlserver`中的数据库。

- 使用前需修改项目中的`App.config`文件中的`coonectionString`字段（如下所示）。

- ```xml
    <?xml version="1.0" encoding="utf-8" ?>
    <configuration>
      <configSections>
      </configSections>
      <connectionStrings>
          <add name="library" connectionString="Data Source=localhost;Initial Catalog=library;User Id=sa;Password=fxh0212++" />
      </connectionStrings>
    </configuration> 
    ```

## 开发环境

- Windows10 19041.329
- SQL Server2017
- NET Framework 4 Client Profile
- Visual Studio 2019

- Blend for Visual Studio 2019