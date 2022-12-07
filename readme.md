# Read Me
## Features

- generates a template based on the client infos.


## Explained more : 
- [ServiceCustomer] : deals with Customer Table Operations (CRUD)
- [TemplateService] : deals with Template Table Operations (CRUD)
- [BackEndService] : OverAll library exposing preferred Node
- [FormHostingApp] : Console APp to start the Server.
## Installation
### requirements
- Postgresql 13
- Dotnet6
- dotnetframework 4.8
### Config : 
[ServiceCustomer] and  [TemplateService]  provide a app.config file where the connection string is provided.
Make sure to change it :
```<connectionStrings>
		<add name="PostgresqlDBContext" connectionString="host=localhost;port=5432;database=TestServices;user id=postgres;password=1" providerName="Npgsql" />
	</connectionStrings>```