using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AbstractFactory
{
	//public GliderFactory gliderFactory;
	//public AircraftFactory aircraftFactory;
	//public RocketFactory rocketFactory;
	
	public IPlane createItem(Requirements reqs)
	{
		if (reqs.rocket)
		{
			RocketFactory rocketFactory = new RocketFactory();
			return rocketFactory.ManufactureRocket(reqs);
		}
		else if (reqs.numberOfEngines > 0)
		{
			Debug.Log("Test");
			AircraftFactory aircraftFactory = new AircraftFactory();
			return aircraftFactory.ManufacturePoweredAircraft(reqs);
			
		} else
		{
			GliderFactory gliderFactory = new GliderFactory();
			return gliderFactory.ManufactureGlider(reqs);
		}
	}
}
