﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemObject item;
    private Transform canvas;


       private void Start() {
        canvas = gameObject.transform.Find("Canvas");

    }

    private void OnTriggerEnter(Collider other) {
        canvas.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other) {
        canvas.gameObject.SetActive(false);
    }

   
}
