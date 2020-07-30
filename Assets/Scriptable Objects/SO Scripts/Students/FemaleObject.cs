using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Female Student", menuName = "Person/Student/Female")]
public class FemaleObject : StudentObject
{
       private void Awake() {
        gender = studentGender.Female;
    }
}
