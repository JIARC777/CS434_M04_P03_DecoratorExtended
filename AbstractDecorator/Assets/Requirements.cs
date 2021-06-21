using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Requirements class is a data container to hold any specifications that need to be considered when being sent to factories
// Determines which factory to send request to as well
public class Requirements
{
    public bool rocket;
    public int numberOfEngines;
    public int numberOfWings;
}
