package com.designpatterns.model;

import com.designpatterns.behaviors.FlyNoWay;
import com.designpatterns.behaviors.Quack;

public class ModelDuck extends Duck 
{
	public ModelDuck()
	{
		flyBehavior = new FlyNoWay();
		quackBehavior = new Quack();
	}
	
	public void display() 
	{
		System.out.println("I\'m a model duck");
	}
}
