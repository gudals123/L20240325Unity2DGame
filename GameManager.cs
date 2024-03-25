class GameManager : Component
{
    public bool isGameOver;
    public bool isNextStage;

    protected Timer gameOverTimer;
    protected Timer nextStageTimer;


    public GameManager()
    {
        isGameOver = false;
        isNextStage = false;
        gameOverTimer = new Timer(3000, ProcessGameOver);
        nextStageTimer = new Timer(2000, ProcessNextStager);
    }

    public void ProcessGameOver()
    {
        Engine.GetInstance().Stop();
        Console.Clear();
        Console.WriteLine("GameOver");
    }
    public void ProcessNextStager()
    {
        Console.Clear();
        Console.WriteLine("Congraturation.");
        Console.ReadKey();
        Engine.GetInstance().NextLoadScene("Level02.map");
    }

    public override void Update()
    {
        if (isGameOver)
        {
            gameOverTimer.Updata();
        }

        if (isNextStage)
        {
            nextStageTimer.Updata();
        }
    }



}

