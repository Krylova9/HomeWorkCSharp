namespace Homework4
{
    public class Counter
    {
        public delegate void Metod();

        public event Metod? result;

        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 77)
                {
                    result?.Invoke();
                }

            }
        }
    }
}