namespace Events.App
{
    public class NumberGenerator
    {
        private readonly Random r = new();
        private event NumberHandler OnGenerated;

        public void Start()
        {
            while (true)
            {
                int n = r.Next(100);

                if(OnGenerated != null)
                {
                    NumberEventArgs args = new() { Number = n };
                    OnGenerated(this, args);
                }

                Thread.Sleep(3000);
            }
        }

        public void AddNumberHandler(NumberHandler handler) => 
            OnGenerated += handler;
    }
}
