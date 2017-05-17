package com.designpatterns.behaviors;

import com.designpatterns.strategy.FlyBehavior;

public class FlyNoWay implements FlyBehavior 
{
	public void fly() 
	{
		System.out.println("I can\'t fly");
	}
}
