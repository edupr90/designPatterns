using System;

using System.Collections;
namespace ObserverPattern
{
    public class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        public WeatherData()
        {
            
        }
    }
}
