namespace Yogurt.NET.AspNetCore;

public sealed class HealthyCheckFactory
{
    private IReadOnlyList<IHealthyCheck> _healthyChecks;

    public HealthyCheckFactory(IReadOnlyList<IHealthyCheck> healthyChecks)
    {
        _healthyChecks = healthyChecks;
    }
    
}