//Director Or Client
using Builder;

Console.WriteLine("Hello, World!");
var propertyBuilder = new PropertyBuilder();
propertyBuilder.SetType("Home");
propertyBuilder.SetAddress("10th Abd El Halim Mohamed street Dar Elsalam Cairo");
propertyBuilder.WithBackYard(true);
propertyBuilder.WithPool(true);
propertyBuilder.WithPlayGround(false);
propertyBuilder.SetPrice(2500m);

var property=propertyBuilder.Build();

Console.WriteLine(property);
