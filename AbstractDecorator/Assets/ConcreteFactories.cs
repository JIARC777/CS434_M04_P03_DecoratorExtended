using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PoweredAircraftFactory: MonoBehaviour
{
	GameObject product;
	public void ManufacturePoweredAircraft(Requirements aircraftReqs)
	{
		switch (aircraftReqs.numberOfWings)
		{
			case 1:
				if (aircraftReqs.numberOfEngines == 1)
				{
					product = Instantiate(Resources.Load("1Wing1EngineAircraft", typeof(GameObject))) as GameObject;
					break;
				}
				if (aircraftReqs.numberOfEngines == 2)
				{
					product = Instantiate(Resources.Load("1Wing2EngineAircraft", typeof(GameObject))) as GameObject;
					break;
				}
				Debug.Log("The factory is unable to create the requested Object");
				break;
			case 2:
				if (aircraftReqs.numberOfEngines == 1)
				{
					product = Instantiate(Resources.Load("2Wing1EngineAircraft", typeof(GameObject))) as GameObject;
					break;
				}
				if (aircraftReqs.numberOfEngines == 2)
				{
					product = Instantiate(Resources.Load("2Wing2EngineAircraft", typeof(GameObject))) as GameObject;
					break;
				}
				Debug.Log("The factory is unable to create the requested Object");
				break;
			default:
				Debug.Log("The factory is unable to create the requested Object");
				break;
		}
	}
}