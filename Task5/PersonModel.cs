namespace Itra_Task5;

public enum Region
{
    Poland,
    Germany,
    UnitedStates
}
public class PersonModel
{
    public int Index { get; set; }
    public int RandomID { get; set; }
    public string FullName { get; set; } = String.Empty;
    public string Address { get; set; } = String.Empty;
    public string Number { get; set; } = String.Empty;
 }
