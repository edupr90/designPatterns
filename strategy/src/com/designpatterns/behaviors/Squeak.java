package com.designpatterns.behaviors;

import com.designpatterns.strategy.QuackBehavior;

public class Squeak implements QuackBehavior 
{
	public void quack() 
	{
		System.out.println("Squeak");
	}
}
