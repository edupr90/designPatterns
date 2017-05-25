using System;

using System.Collections.Generic;
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
            observers = new List<Observer>();
        }

        public void RegisterObserver(Observer o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
           //int i = observers.IndexOf(o);
           //if (i >= 0)
           // { 
                observers.Remove(o);    
            //}
        }

        public void NotifyObserver()
        {
            //int i = 0;
            //if(i < observers.Count)
            //{
                foreach( Observer o in observers)
                {
                    o.Update(temperature,humidity,pressure);
                }
            //}
        }
        public void measurementsChanged()
        {
            NotifyObserver();
        }
		public void setMeasurements(float temperature, float humidity, float pressure)
		{
			this.temperature = temperature;
			this.humidity = humidity;
			this.pressure = pressure;
			measurementsChanged();
		}
    }
}
