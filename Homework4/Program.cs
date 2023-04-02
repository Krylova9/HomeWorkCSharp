namespace Homework4
{
    public static class Program 
    {
        public static void Main()
        {
            var Counter = new Counter();
            var Handler1 = new Handler1();
            var Handler2 = new Handler2();

            Counter.result += Handler1.Message;
            Counter.result += Handler2.Message;

            Counter.Count();
        } 
       
    } 

}
