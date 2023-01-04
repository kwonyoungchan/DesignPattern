
public  abstract class Duck
{
    // 인터페이스 사용할거임
    public IQuackBehavior QuackBehavior { get; set; }
    public IFlyBehavior FlyBehavior { get; set; }

    //동적으로 오리의 행동을 지정하기 위한 메소든
    public void SetFlyBehavior(IFlyBehavior fb)
    { 
        FlyBehavior = fb;
    }
    public void SetQuackBehavior(IQuackBehavior qb)
    { 
        QuackBehavior = qb;
    }
    
    //오리 시뮬레이터에 공통적으로 들어갈 메소드

    public abstract void Display();
    
    //오리가 나는 행동
    public void PerformFly()
    {
        FlyBehavior.Fly();
    }
    //오리가 우는 행동
    public void PerformQuack()
    {
        QuackBehavior.Quack();
    }
    //모든 행동 출력
    public void PerformAll()
    {
        Display();
        QuackBehavior.Quack();
        FlyBehavior.Fly();
    }
}
