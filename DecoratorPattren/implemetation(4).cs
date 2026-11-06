
//the way to call the class in .NET Core is to use the dependency injection. So we will register the class in the service collection and then we will call it in the main method.
var services = new ServiceCollection();

// 1. Register the original repository
serevices.AddScoped<IuserRepository, SqlUserRepository>();

// 2. Register the decorator with caching functionality
//use suroter to decorate the implementation seamlesly

services.Decorate<IuserRepository,cachedUserRepository>();

var serviceProvider = services.BuildServiceProvider();

// 3. Resolve the interface
// The appliaction onl knows about the IuserRepository interface, but it will get the decorated version with caching functionality.

var repository  = serviceProvider.GetRequiredService<IuserRepository>();

