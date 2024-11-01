// Usage
// Subclasses for combinations
public class MilkCoffee : Coffee
{
    public override string GetDescription() => base.GetDescription() + ", Milk";
    public override double GetCost() => base.GetCost() + 0.50;
}

