public sealed class SingleTon
{
    //Institation is deferred until the value propert is accssesd for the first time
    //it is fully thread-safe by default
    private static singleTon _instance;
    private int _counter;
    // A private constructorprevents external instiation via "new" keword
    private singleTon
    {
    }

    public static singleTon Instance
    {
       get{
            if(_instance==null)
            {
                _instance = new singleton;
            }
            return _instance;
       }
    }
    public void IncrementCounter()
    {
        _counter++;
    }
}