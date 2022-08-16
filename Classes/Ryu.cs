public class Ryu : Fighter
{
    public Ryu(KickBehavior kickBehavior, JumpBehavior jumpBehavior)
    : base (kickBehavior, jumpBehavior)
    {
    }

    public override void Display()
    {
        Console.WriteLine("Ryu");
    }
}