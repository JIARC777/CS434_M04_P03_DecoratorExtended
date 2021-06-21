using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Interface for any spawnable object
public interface IPlane
{
	void spawnItem();
	void RemoveObject();
}

// Base class to extend with specific models
public class BasicPlane: IPlane
{
	public GameObject plane;
	// Dummy function to override
	public virtual void spawnItem() { Debug.Log("Base Spawn"); }
	// Every object is destroyed in the same way
	public void RemoveObject()
	{
		GameObject.Destroy(plane);
	}
}
// Specific Plane models using Resources.Load() to instatiate
public class OneWingGlider: BasicPlane
{
	public override void spawnItem()
	{
		plane = GameObject.Instantiate(Resources.Load<GameObject>("1WingGlider"));
	}
}
public class TwoWingGlider : BasicPlane
{
	GameObject product;
	public override void spawnItem()
	{
		plane = GameObject.Instantiate(Resources.Load<GameObject>("2WingGlider"));
	}
}
public class ThreeWingGlider : BasicPlane
{
	public override void spawnItem()
	{
		plane = GameObject.Instantiate(Resources.Load<GameObject>("3WingGlider"));
	}
}
public class FourWingGlider : BasicPlane
{
	GameObject product;
	public override void spawnItem()
	{
		plane = GameObject.Instantiate(Resources.Load<GameObject>("4WingGlider"));
	}
}

public class OneWingOneEnginePlane : BasicPlane
{
	GameObject product;
	public override void spawnItem()
	{
		plane = GameObject.Instantiate(Resources.Load<GameObject>("1Wing1EngineAircraft"));
	}
}
public class TwoWingOneEnginePlane : BasicPlane
{
	GameObject product;
	public override void spawnItem()
	{
		plane = GameObject.Instantiate(Resources.Load<GameObject>("2Wing1EngineAircraft"));
	}
}
public class OneWingTwoEnginePlane : BasicPlane
{
	public override void spawnItem()
	{
		plane = GameObject.Instantiate(Resources.Load<GameObject>("1Wing2EngineAircraft"));
	}
}
public class TwoWingTwoEnginePlane : BasicPlane
{
	public override void spawnItem()
	{
		plane = GameObject.Instantiate(Resources.Load<GameObject>("2Wing2EngineAircraft"));
	}
}

public class OneWingRocket : BasicPlane
{
	public override void spawnItem()
	{
		plane = GameObject.Instantiate(Resources.Load<GameObject>("1WingRocket"));
	}
}
public class TwoWingRocket : BasicPlane
{
	public override void spawnItem()
	{
		plane = GameObject.Instantiate(Resources.Load<GameObject>("2WingRocket"));
	}
}
public class ThreeWingRocket : BasicPlane
{
	public override void spawnItem()
	{
		plane = GameObject.Instantiate(Resources.Load<GameObject>("3WingRocket"));
	}
}
public class FourWingRocket : BasicPlane
{
	public override void spawnItem()
	{
		plane = GameObject.Instantiate(Resources.Load<GameObject>("4WingRocket"));
	}
}