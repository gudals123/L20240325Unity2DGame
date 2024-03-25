using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        //List<int> gameObjects = new List<int> { 20, 17, 3, 5, 2, 5, 18, 16, 1, 9 };

        //for (int i = 0; i < gameObjects.Count; i++)
        //{
        //    for(int j = i+1; j < gameObjects.Count; j++)
        //    {
        //        if (gameObjects[i] > gameObjects[j])
        //        {
        //            int temp = gameObjects[i];
        //            gameObjects[i] = gameObjects[j];
        //            gameObjects[j] = temp;
        //        }
        //    }
        //}

        //foreach(var i in gameObjects)
        //{
        //    Console.WriteLine(i);
        //}

        Engine engine = Engine.GetInstance();

        engine.Init();
        engine.LoadScene("level01.map");
        engine.Run();
        engine.Term();
    }
}


