public abstract class Fighter
{
    KickBehavior _kickBehavior;
    JumpBehavior _jumpBehavior;

    public Fighter(KickBehavior kickBehavior, JumpBehavior jumpBehavior)
    {
        _jumpBehavior = jumpBehavior;
        _kickBehavior = kickBehavior;
    }

    public void Punch()
    {
        Console.WriteLine("Default punch");
    }

    public void Kick()
    {
        //Delegate to kick behavior
        _kickBehavior.Kick();
    }

    public void Jump()
    {
        //Delegate to kick behavior
        _jumpBehavior.Jump();
    }

    public void Roll()
    {
        Console.WriteLine("Default Roll");
    }

    public void SetJumpBehavior(JumpBehavior jumpBehavior)
    {
        _jumpBehavior = jumpBehavior;
    }

    public void SetKickBehavior(KickBehavior kickBehavior)
    {
        _kickBehavior = kickBehavior;    
    }

    public abstract void Display();
}