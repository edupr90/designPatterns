using System;
namespace ObserverPattern
{
    public interface Subject
    {
        //Metodos definido
        void RegisterObserver(Observer o);
        void RemoveObserver(Observer o);
        void NotifyObserver();
    }
}
