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

}
