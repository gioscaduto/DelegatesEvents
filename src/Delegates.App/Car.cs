namespace Delegates.App
{
    public class Car
    {
        public int Id { get; private set; }

        public Car(int id)
        {
            Id = id;
        }

        public void TrafficLightChanged(Color color)
        {
            var message = $"Car {Id} notified, traffic light color: {color}, ";

            switch (color)
            {
                case Color.Red:
                    message += "stop the car";
                    break;
                case Color.Green:
                    message += "speed up the car";
                    break;
                case Color.Yellow:
                    message += "brake the car";
                    break;
                default:
                    throw new InvalidOperationException("Invalid color"); 
            }

            Console.WriteLine(message);
        }
    }
}
