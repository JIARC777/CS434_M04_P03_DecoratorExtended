using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftFactory
{
	IPlane plane;
	public IPlane ManufacturePoweredAircraft(Requirements aircraftReqs)
	{
		switch (aircraftReqs.numberOfWings)
		{
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
				//Debug.Log("The A factory is unable to create the requested Object");
				return new OneWingGlider();
			default:
				//Debug.Log("The A factory is unable to create the requested Object");
				return new OneWingGlider();
		}
	}
}

