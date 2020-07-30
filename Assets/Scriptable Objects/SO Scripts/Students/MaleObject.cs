using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Male Student", menuName = "Person/Student/Male")]
public class MaleObject : StudentObject
{
    private void Awake() {
        gender = studentGender.Male;
    }
}
