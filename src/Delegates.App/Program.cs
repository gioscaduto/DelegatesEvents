using Delegates.App;

TrafficLight trafficLight = new();

for (int i = 1; i <= 3; i++)
{
    Car car = new(i);
    trafficLight.AddCallBack(car.TrafficLightChanged);
}

trafficLight.Start();
Console.ReadKey();