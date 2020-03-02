using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketFactory
{
	GameObject product;
	public IPlane ManufactureRocket(Requirements aircraftReqs)
	{
		
		switch (aircraftReqs.numberOfWings)
		{
			case 1:
			//	product = Instantiate(Resources.Load("1WingRocket", typeof(GameObject))) as GameObject;
				return new OneWingRocket();
			case 2:
				//	product = Instantiate(Resources.Load("2WingRocket", typeof(GameObject))) as GameObject;
				return new TwoWingRocket();
			case 3:
				//	product = Instantiate(Resources.Load("3WingRocket", typeof(GameObject))) as GameObject;
				return new ThreeWingRocket();
			case 4:
				//	product = Instantiate(Resources.Load("4WingRocket", typeof(GameObject))) as GameObject;
				return new FourWingRocket();
			default:
				//Debug.Log("The factory is unable to create the requested Object");
				// use one wing glider as a default case
				return new OneWingGlider();

		}
	}
}
