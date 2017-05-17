package com.designpatterns.simulator;

import com.designpatterns.behaviors.FlyRocketPowered;
import com.designpatterns.model.Duck;
import com.designpatterns.model.MallardDuck;
import com.designpatterns.model.ModelDuck;

public class MiniDuckSimulator 
{
	/**
	 * @param args
	 */
	public static void main(String[] args) 
	{
		Duck mallard = new MallardDuck();
		mallard.performQuack();
		mallard.performFly();
		Duck model = new ModelDuck();
		model.performFly();
		model.setFlyBehavior(new FlyRocketPowered());
		model.performFly();
	}
}
