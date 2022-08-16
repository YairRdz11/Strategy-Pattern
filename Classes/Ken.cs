public class Ken : Fighter
{
    public Ken(KickBehavior kickBehavior, JumpBehavior jumpBehavior):
    base(kickBehavior, jumpBehavior) {}
    public override void Display()
    {
        Console.WriteLine("Ken");
    }
}