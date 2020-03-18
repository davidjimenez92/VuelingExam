## Vueling Exam

### Implementation
This is an exercise based on the DDD architecture, in which apart from the architecture itself we will introduce the principle of injecting dependencies with Autofac, the principle of segregation of interfaces by dividing the interfaces into smaller ones that can be reused, in the tests I created a bookstore to use the DRY principle
I also use design patterns such as the patron Builder in Autofac when creating your configuration.

The solution consists of 6 projects plus test projects.

1. [Business Facede]() is the main project from which the solution will be run. It is a web api in which inject dependencies of all layers including loggin dependency.
2. [Business Filter Framework]() this project is a library of error filters that we will send to the [Business Facede]()
3. [Application Logic]() is the part that takes care of the business logic, communicates with [Business Facade]() and [Infrastucture Repositories]().
4. [Domain Entities]() is the project where we will store the entities of my application.
5. [Infrastucture Repositories]() here will be realized the logic for connection and operations with the file, This project will send the results obtained to [Application Logic]()
6. [Test Framework]() is a library to use the DRY principle and implement it in the integration tests.

### UML Diagram

### Technology stack
`Visual Studio 2019 Comunity edition | C# | .NET Framework`

### Libraries 
1. `Autofac v5.1.2`
2. `Autofac.WebApi2 v5.0.0`
3. `Autofac.Extras.Moq v5.0.0`
4. `Dapper v2.0.30`
5. `log4net v2.0.8`

### Author
David Jiménez Miguel