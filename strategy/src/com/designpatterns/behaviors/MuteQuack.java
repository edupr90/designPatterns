package com.designpatterns.behaviors;

import com.designpatterns.strategy.QuackBehavior;

public class MuteQuack implements QuackBehavior 
{
	public void quack()
	{
		System.out.println("<< Silence >>");
	}
}
