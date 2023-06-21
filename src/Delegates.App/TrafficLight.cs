namespace Delegates.App
{
    public class TrafficLight
    {
        private Color color = Color.Red;
        private TrafficLightHandler? callbacks;
       
        public void Start()
        {
            while (true)
            {
                ChangeColor();
                
                Thread.Sleep(3000);
            }
        }

        public void AddCallBack(TrafficLightHandler handler) =>
            callbacks += handler;

        private void ChangeColor()
        {
            switch (color) 
            { 
                case Color.Red:
                    color = Color.Green;
                    break;
                case Color.Green:
                    color = Color.Yellow;
                    break;
                case Color.Yellow:
                    color = Color.Red;
                    break;
                default:
                    throw new InvalidOperationException("Invalid color");
            }

            Console.WriteLine();
            Console.WriteLine($"Traffic light change to: {color}{Environment.NewLine}");
            
            if (callbacks != null) 
            {
                callbacks(color);
            }
        }
    }
}
