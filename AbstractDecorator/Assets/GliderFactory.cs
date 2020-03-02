using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GliderFactory
{
	GameObject product;
	public IPlane ManufactureGlider(Requirements gliderReqs)
	{
		switch (gliderReqs.numberOfWings)
		{
			case 1:
				//	product = Instantiate(Resources.Load("1WingGlider", typeof(GameObject))) as GameObject;
				return new OneWingGlider();

			case 2:
				//	product = Instantiate(Resources.Load("2WingGlider", typeof(GameObject))) as GameObject;
				return new TwoWingGlider();

			case 3:
				//	product = Instantiate(Resources.Load("3WingGlider", typeof(GameObject))) as GameObject;
				return new ThreeWingGlider();

			case 4:
				//	product = Instantiate(Resources.Load("4WingGlider", typeof(GameObject))) as GameObject;
				return new FourWingGlider();

			default:
				//Debug.Log("The factory is unable to create the requested Object");
				return new OneWingGlider();

		}
	}
}
