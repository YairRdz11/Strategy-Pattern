//Let us make some behaviors first
JumpBehavior shortJump = new ShorJump();
JumpBehavior longJump = new LongJump();
KickBehavior tornadoKick = new TornadoKick();

//Make a fighter with desired behaviors
Fighter ken = new Ken(tornadoKick, shortJump);
ken.Display();

//Test behaviors
ken.Punch();
ken.Kick();
ken.Jump();

//Change behavior dinamically (algorithms are
//interchangeables)
ken.SetJumpBehavior(longJump);
ken.Jump();
