using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSender : MonoBehaviour
{

    public StudentObject npc;
    public Dialogue conversation;

    public GameObject conversationWindow;
    private float timer;
    public Text npc_Name;
    public Text descr;
    bool open = false;
    private int charIndex;

    private void Update() {
        if (open){
            
            writeText();
        }
    }

    private void writeText(){

            timer -= Time.deltaTime;
            if (timer <= 0f && charIndex <= conversation.context.Length-1){
                timer += 0.05f;
                charIndex++;
                descr.text = conversation.context.Substring(0, charIndex);
            }
        

    }

    public void OpenConversation(){
        conversationWindow.SetActive(true);
        npc_Name.text = conversation.name_person;
        open = true;

    }

    public void CloseConversation(){
        conversationWindow.SetActive(false);
        open = false;
        descr.text = "";
        npc_Name.text = "";
    }
}
