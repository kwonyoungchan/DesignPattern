using System;

public class Mute : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("아무소리도 내지 않습니다.");
    }
}
