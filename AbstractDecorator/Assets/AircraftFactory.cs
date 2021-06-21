using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This specific class handles the spawning of powered aircraft models based on specifications for number of wings and number of engines
public class AircraftFactory
{
	IPlane plane;
	// Returns anything using the IPlane interface to the requesting system
	public IPlane ManufacturePoweredAircraft(Requirements aircraftReqs)
	{
		// Switch case for number of wings
		switch (aircraftReqs.numberOfWings)
		{
			// Old version of factory shown where instantiation happens on the spot
			// Refactored to pass the object to create
			case 1:
				if (aircraftReqs.numberOfEngines == 1)
				{
					//	product = Instantiate(Resources.Load("1Wing1EngineAircraft", typeof(GameObject))) as GameObject;
					return new OneWingOneEnginePlane();
				}
				if (aircraftReqs.numberOfEngines == 2)
				{
					//	product = Instantiate(Resources.Load("1Wing2EngineAircraft", typeof(GameObject))) as GameObject;
					return new OneWingTwoEnginePlane();
				}
				//Debug.Log("The  A factory is unable to create the requested Object");
				return new OneWingGlider();
			case 2:
				if (aircraftReqs.numberOfEngines == 1)
				{
					//	product = Instantiate(Resources.Load("2Wing1EngineAircraft", typeof(GameObject))) as GameObject;
					return new TwoWingOneEnginePlane();
				}
				if (aircraftReqs.numberOfEngines == 2)
				{
					//	product = Instantiate(Resources.Load("2Wing2EngineAircraft", typeof(GameObject))) as GameObject;
					return new TwoWingTwoEnginePlane();
				}
				// Note OneWingGlider is the default model and there are no powered aircraft with more than two wings
				// because the selector goes up to 4 wings, anything higher than 2 automatically spawns the default
				//Debug.Log("The A factory is unable to create the requested Object");
				return new OneWingGlider();
			default:
				//Debug.Log("The A factory is unable to create the requested Object");
				return new OneWingGlider();
		}
	}
}

