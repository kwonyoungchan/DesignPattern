using System;

public class MallordDuck : Duck
{
    // mallord duck의 특성을 부여
    public MallordDuck()
    {
        QuackBehavior = new Quack();
        FlyBehavior = new Flyable();
    }
    // 부모 클래스의 메소드를 오버라이딩
    public override void Display()
    {
        Console.WriteLine("I'm mallord Duck!");
    }

}