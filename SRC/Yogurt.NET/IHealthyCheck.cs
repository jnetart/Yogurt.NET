namespace Yogurt.NET;

public interface IHealthyCheck
{
    Task<CheckResult> CheckAsync();
}