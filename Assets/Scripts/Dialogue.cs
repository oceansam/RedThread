using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue 
{

    public bool isActive;
    public string name_person;
    [TextArea(10,20)]
    public string context;


  
}
