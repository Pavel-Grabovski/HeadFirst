﻿namespace HeadFirst.Observer.Standart;

public interface IObserver
{
    public void Update(float temp, float humidity, float pressure);
}
