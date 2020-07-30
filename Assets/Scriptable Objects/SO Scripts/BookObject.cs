using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Book Object", menuName = "InventorySystem/Items/Book")]
public class BookObject : ItemObject
{

    public void Awake(){
        type = ItemType.Book;
    }
  
}
