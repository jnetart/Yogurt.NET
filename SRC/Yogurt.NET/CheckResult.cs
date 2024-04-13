namespace Yogurt.NET;

public sealed class CheckResult
{
    public bool? IsConfigured { get; set; }
    public bool? IsChecked { get; set; }
    public CheckState Status { get; set; } = CheckState.Nil;
    
    public enum CheckState: byte
    {
        Nil,
        Green,
        Yellow,
        Red,
    }
}