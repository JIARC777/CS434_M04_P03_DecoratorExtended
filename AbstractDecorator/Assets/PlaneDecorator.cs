﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlaneDecorator: IPlane
{
    public IPlane decoratedPlane;
    public PlaneDecorator(IPlane plane) { plane = decoratedPlane; }
    public void spawnItem() { }
    public virtual void RemoveObject() { }
    
}

public class WithMissles: PlaneDecorator
{
    GameObject model;
    public WithMissles(IPlane plane) : base(plane)
    {
        GameObject prefab = Resources.Load<GameObject>("Missle");
        model = GameObject.Instantiate(prefab);
    }
    public override void RemoveObject()
    {
        GameObject.Destroy(model);
    }
}
public class WithMachineGun : PlaneDecorator
{
    GameObject model;
    public WithMachineGun(IPlane plane) : base(plane)
    {
        GameObject prefab = Resources.Load<GameObject>("Gun");
        model = GameObject.Instantiate(prefab);
    }
    public override void RemoveObject()
    {
        GameObject.Destroy(model);
    }
}