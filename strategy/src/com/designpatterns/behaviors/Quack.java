package com.designpatterns.behaviors;

import com.designpatterns.strategy.QuackBehavior;

public class Quack implements QuackBehavior 
{
	public void quack() 
	{
		System.out.println("Quack!");
	}
}
