﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Key Object", menuName = "InventorySystem/Items/Key")]
public class KeyObject : ItemObject
{
   
    public void Awake() {
        type = ItemType.Key;

    }
}
