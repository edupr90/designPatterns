package com.designpatterns.behaviors;

import com.designpatterns.strategy.FlyBehavior;

public class FlyRocketPowered implements FlyBehavior 
{
	public void fly() 
	{
		System.out.println("I\'m flying with a rocket!");
	}
}
