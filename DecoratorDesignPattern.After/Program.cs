// Usage
ICoffee coffee = new Coffee();
coffee = new MilkDecorator(coffee); // Adding milk
coffee = new SugarDecorator(coffee); // Adding sugar
Console.WriteLine($"{coffee.GetDescription()} costs {coffee.GetCost()}");