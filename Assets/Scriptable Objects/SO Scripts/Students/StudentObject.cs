using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum studentGender{
    Male,
    Female   
}



public class StudentObject : ScriptableObject
{

    public GameObject prefab;
    public studentGender gender;
    public string stuName;
    //public string[] responseArray = new string[3];

    [TextArea(2,5)]
    public List<string> nodeSpeech = new List<string>();

  
   
  
   


   
}
