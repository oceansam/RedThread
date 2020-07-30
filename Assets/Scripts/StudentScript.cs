using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentScript : MonoBehaviour
{

    public StudentObject student;
    private Transform promptCanvas;
    private Transform dialogueCanvas;   


    private void Start() {
        promptCanvas = gameObject.transform.Find("InteractPrompt");
        
    }

    private void OnTriggerEnter(Collider other) {

        setOff(true);
    }

    private void OnTriggerExit(Collider other) {
        setOff(false);
    }

    private void setOff(bool p){
        promptCanvas.gameObject.SetActive(p);
    }
    public void Conversation (){
        setOff(false);

    }

    
}
