using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentScript : MonoBehaviour
{

    public StudentObject student;
    private Transform promptCanvas;
    private Transform dialogueCanvas;
    public DialogueSender temp;
    public bool dialogueActive = false;
    //public GameObject tweener;




    
    private void Start() {
        promptCanvas = gameObject.transform.Find("InteractPrompt");


    }

    private void OnTriggerEnter(Collider other) {
        setOff(true);
    }

    private void OnTriggerExit(Collider other) {
      
        conversationPrompt(false);
        
        setOff(false);
        

    }

    public void conversationPrompt(bool p){
        if (p)
        {
            temp.OpenConversation();
        }
        else if (!p){
            temp.CloseConversation();
        }
    }

   

    private void setOff(bool p){
        promptCanvas.gameObject.SetActive(p);
    }
    // public void Conversation (){
    //     setOff(false);
        
        

    // }

    
}
