using System;
namespace ObserverPattern
{
    public class CurrentConditionDisplay : Observer, DisplayElements
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();

        }

        public void Display()
        {
            Console.WriteLine("Current conditions:  " + temperature + " F degree and " + humidity + "% humidity");    
        }

    }
}
