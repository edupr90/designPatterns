package com.designpatterns.model;

import com.designpatterns.behaviors.FlyWithWings;
import com.designpatterns.behaviors.Quack;

public class MallardDuck extends Duck 
{
	public MallardDuck() 
	{
		flyBehavior = new FlyWithWings();
		quackBehavior = new Quack();
	}

	public void display() 
	{
		System.out.println("I\'m a real Mallard duck");
	}
}
