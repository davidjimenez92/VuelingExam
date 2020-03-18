## Vueling Exam
As a imperial programmer your receive the order of implement a new web service that allows to register any rebeld identification.
The empire has conquered all universe, but it still remains some group of hidden rebelds. Dark forces, soldiers for the empire, distributed over all know galaxies and solar systems forces empire's citizens to be identified. They need you to develop a distributed service that would be able to be called from any location over the universe.
As interoperability is a must, you decide to use an old fashioned and very extended technology called wcf web services. The web service should be RestFull to be called from anywhere an http/tcp network is. The web service has to expose a method that accept a list of strings with the name of the rebeld and name of the planet, and response true is register goes fine. The regiter has to be done to file with a datetime with the string "rebeld (name) on (planet) at (datetime)".

### Implementation
This is an exercise based on the DDD architecture, in which apart from the architecture itself we will introduce the principle of injecting dependencies with Autofac, the principle of segregation of interfaces by dividing the interfaces into smaller ones that can be reused, in the tests I created a bookstore to use the DRY principle
I also use design patterns such as the patron Builder in Autofac when creating your configuration.

The solution consists of 6 projects plus test projects.

1. [Business Facede](https://github.com/davidjimenez92/VuelingExamm/tree/master/VuelingExam.Business.Facade) is the main project from which the solution will be run. It is a web api in which inject dependencies of all layers including loggin dependency.
2. [Business Filter Framework](https://github.com/davidjimenez92/VuelingExamm/tree/master/VuelingExam.Business.Filters.Framework) this project is a library of error filters that we will send to the [Business Facede](https://github.com/davidjimenez92/VuelingExamm/tree/master/VuelingExam.Business.Facade)
3. [Application Logic](https://github.com/davidjimenez92/VuelingExamm/tree/master/VuelingExam.Application.Logic) is the part that takes care of the business logic, communicates with [Business Facade](https://github.com/davidjimenez92/VuelingExamm/tree/master/VuelingExam.Business.Facade) and [Infrastucture Repositories](https://github.com/davidjimenez92/VuelingExamm/tree/master/Vueling.Infrastucture.Repositories).
4. [Domain Entities](https://github.com/davidjimenez92/VuelingExamm/tree/master/VuelingExam.Domain.Entities) is the project where we will store the entities of my application.
5. [Infrastucture Repositories](https://github.com/davidjimenez92/VuelingExamm/tree/master/Vueling.Infrastucture.Repositories) here will be realized the logic for connection and operations with the file, This project will send the results obtained to [Application Logic](https://github.com/davidjimenez92/VuelingExamm/tree/master/VuelingExam.Application.Logic)
6. [Test Framework](https://github.com/davidjimenez92/VuelingExamm/tree/master/VuelingExam.Test.Framework) is a library to use the DRY principle and implement it in the integration tests.

### UML Diagram
![alt text](https://github.com/davidjimenez92/VuelingExamm/blob/master/ddd.png)
### Technology stack
`Visual Studio 2019 Comunity edition | C# | .NET Framework 4.7.2`

### Libraries 
1. `Autofac v5.1.2`
2. `Autofac.WebApi2 v5.0.0`
3. `Autofac.Extras.Moq v5.0.0`
4. `Dapper v2.0.30`
5. `log4net v2.0.8`

### Author
David Jiménez Miguel
