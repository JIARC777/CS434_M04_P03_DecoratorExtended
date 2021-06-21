using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This class acts as a master factory that reads requirements and sends them to the factories it is aware of
public class AbstractFactory
{
	//public GliderFactory gliderFactory;
	//public AircraftFactory aircraftFactory;
	//public RocketFactory rocketFactory;
	
	// Read the reqs, create the right factory, and return the result sent from the factory to the client
	public IPlane createItem(Requirements reqs)
	{
		if (reqs.rocket)
		{
			RocketFactory rocketFactory = new RocketFactory();
			return rocketFactory.ManufactureRocket(reqs);
		}
		else if (reqs.numberOfEngines > 0)
		{
			
			AircraftFactory aircraftFactory = new AircraftFactory();
			return aircraftFactory.ManufacturePoweredAircraft(reqs);
			
		} else
		{
			GliderFactory gliderFactory = new GliderFactory();
			return gliderFactory.ManufactureGlider(reqs);
		}
	}
}
