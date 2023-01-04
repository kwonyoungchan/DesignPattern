using System;
public class Quack : IQuackBehavior
{
    void IQuackBehavior.Quack()
    {
        Console.WriteLine("꽥 꽥");
    }
}
