﻿using System;
namespace ObserverPattern
{
    public interface Observer
    {
       void Update(float temp, float humidity, float pressure);
    }
}
