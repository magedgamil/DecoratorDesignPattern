// Usage
public class SugarMilkCoffee : MilkCoffee
{
    public override string GetDescription() => base.GetDescription() + ", Sugar";
    public override double GetCost() => base.GetCost() + 0.25;
}

