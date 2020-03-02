using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public bool rocket;
    public bool missles;
    public bool guns;
    public int howManyEngines;
    public int howManyWings;

    public Text numWings;
    public Text numEngines;
    public Text containRocket;
    public Text hasGuns;
    public Text hasMissle;
    // public AbstractFactory factory;

    IPlane plane;
    // Update is called once per frame
    void Update()
    {
        // Every Frame update the requirements to ensure all info is being sent when requested
        if (Input.GetKeyDown("s"))
        {
            Requirements requirements = new Requirements();
            requirements.rocket = rocket;
            requirements.numberOfEngines = howManyEngines;
            requirements.numberOfWings = howManyWings;
            AbstractFactory factory = new AbstractFactory();
            // Send Requirements to factory;
            if (plane != null)
                plane.RemoveObject();
            plane = factory.createItem(requirements);
            Debug.Log(plane.GetType());
            plane.spawnItem();
            if (missles && !guns)
                plane = new WithMissles(plane);
            if (guns && !missles)
                plane = new WithMachineGun(plane);
            if (guns && missles)
                plane = new WithMachineGun(new WithMissles(plane));
            
        }
        // Increment the number of wings with the + -   Clip values between 0 and 4
        if (Input.GetKeyDown("="))
        {
            howManyWings++;
            if (howManyWings > 4)
                howManyWings = 4;
        }
        if (Input.GetKeyDown("-"))
        {
            howManyWings--;
            if (howManyWings < 0)
                howManyWings = 0;
        }
        if (Input.GetKeyDown("r"))
            rocket = !rocket;
        if (Input.GetKeyDown("]"))
        {
            howManyEngines++;
            if (howManyEngines > 2)
                howManyEngines = 2;
        }
        if (Input.GetKeyDown("["))
        {
            howManyEngines--;
            if (howManyEngines < 0)
                howManyEngines = 0;
        }
        if (Input.GetKeyDown("m"))
        {
            missles = !missles;
        }
        if (Input.GetKeyDown("g"))
        {
            guns = !guns;
        }
        numWings.text = howManyWings.ToString();
        numEngines.text = howManyEngines.ToString();
        containRocket.text = rocket.ToString();
        hasGuns.text = guns.ToString();
        hasMissle.text = missles.ToString();

    }
}

