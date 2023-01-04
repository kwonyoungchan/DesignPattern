

    class Program
    {
        static void Main(string[] args)
        {
        MallordDuck mallord = new MallordDuck();
        RedheadDuck redHead = new RedheadDuck();
        RubberDuck rubberDuck = new RubberDuck();
        DecoyDuck decoy = new DecoyDuck();

        mallord.PerformAll();
        redHead.PerformAll();
        rubberDuck.PerformAll();
        decoy.PerformAll();

        //모델 오리의 행동을 동적으로 바꾼다.
        Duck model = new ModelDuck();
        model.PerformFly();
        model.SetFlyBehavior(new FlyRocketPowerd());
        model.PerformFly();

    }

    }

