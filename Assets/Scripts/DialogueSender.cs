using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSender : MonoBehaviour
{

    // Person attributes-
    
    public StudentObject npc; 
    //public Dialogue conversation;
    
    // Responsive Canvas
    [Header("Canvas Properties")]
    public GameObject conversationWindow;
    public GameObject respondWindow;
    bool open = false;

    // Text grabbers
    public Text npc_Name;
    public Text descr;
    public Text option1;
    public Text option2;
    public Text option3;

    // Typewriter variables
 
    private float timer;
    private int charIndex = 0;
    private int sentenceIndex = 0;


    private void Update() {
        
        if (open){ //
            
            if (descr.text == npc.nodeSpeech[sentenceIndex] && Input.GetKeyDown(KeyCode.E)){
                advanceSentence();
            }
            else{
                StartCoroutine(writeText());

            }
          
        }

      

    }

    /*
    * Typewriter effect method, based on time no frame rate.
    */
    IEnumerator writeText(){
        timer -= Time.deltaTime;
            if (timer <= 0f && charIndex <= npc.nodeSpeech[sentenceIndex].Length -1 ){
                timer += 0.03f;
                charIndex++;
            descr.text = npc.nodeSpeech[sentenceIndex].Substring(0, charIndex);
            

        }

        yield return null;

    }

    /*
    * Advance the dialogue to the next sentence and closing if finished.
    */  
    public void advanceSentence(){
        
        if (npc.nodeSpeech.Count -1 == sentenceIndex){

            CloseConversation();

        }

        else{

        sentenceIndex++;
        descr.text = "";
        charIndex = 0;
        }

    }

    /*
    * Methods for opening and closing conversation window.
    */

    public void OpenConversation(){
        //Time.timeScale = 0f;
        conversationWindow.SetActive(true);
        // respondWindow.SetActive(true);
        // option1.text = npc.responseArray[0];
        // option2.text = npc.responseArray[1];
        // option3.text = npc.responseArray[2];
        npc_Name.text = npc.stuName;
        open = true;
        
        
    }

    

    public void CloseConversation(){
        conversationWindow.SetActive(false);
       // respondWindow.SetActive(false);
        open = false;
        descr.text = "";
        npc_Name.text = "";
        charIndex = 0;
    }
}
