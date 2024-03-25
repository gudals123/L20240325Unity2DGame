using static Timer;

class Timer
{
    public ulong executeTime = 0;
    protected ulong elapsedTime = 0;

    public delegate void Callback();
    public event Callback callback;


    public Timer(ulong _executeTime, Callback _callback)
    {
        SetTimer(_executeTime, _callback);
    }

    public void SetTimer(ulong _executeTime, Callback _callback)
    {
        executeTime = _executeTime;
        callback = _callback;
    }

    public void Updata()
    {
        elapsedTime +=Engine.GetInstance().deltaTime;
        if(elapsedTime >= executeTime) 
        {
            //실행
            callback();
            elapsedTime = 0;
        }
    }


}
