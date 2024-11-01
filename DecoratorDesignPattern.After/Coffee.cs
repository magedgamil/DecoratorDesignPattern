// Component Interface
public interface ICoffee
{
    string GetDescription();
    double GetCost();
}

// Concrete Component
public class Coffee : ICoffee
{
    public string GetDescription() => "Coffee";
    public double GetCost() => 5.00;
}

// Base Decorator
public abstract class CoffeeDecorator : ICoffee
{
    private readonly ICoffee _coffee;

    protected CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual string GetDescription() => _coffee.GetDescription();
    public virtual double GetCost() => _coffee.GetCost();
}

// Concrete Decorators
public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => base.GetDescription() + ", Milk";
    public override double GetCost() => base.GetCost() + 0.50;
}

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => base.GetDescription() + ", Sugar";
    public override double GetCost() => base.GetCost() + 0.25;
}


