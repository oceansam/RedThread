using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon Object", menuName = "InventorySystem/Items/Weapon")]
public class WeaponObject : ItemObject
{

    public void Awake(){
        type = ItemType.Weapon;
    }
}
