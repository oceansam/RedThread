using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    
    
    public InventoryObject inventory;
    public CharacterController controller;
    public Transform cam;
    public float playerSpeed = 4f;
    private Animator anim;
    private float triggerInteger = 0f;
    public float smoothTime = 0.1f;
    float turnSmoothVelocity;


    void Start()
    {
    
    controller.center = new Vector3(0f, 1.57f, 0f); // off a bit of testing, (capsule being dumb)
    anim = GetComponent<Animator>();
    }


    
    
    private void OnTriggerStay(Collider other) {
        switch (other.tag){
            case "Item":
                PickUp(other);
                break;
            case "NPC":
                TalkTo(other);
                break;
        }
        
    }
    
   
    // Update is called once per frame
    void Update()
    {
        Walk();
        StartCoroutine(Sprint());
        
   

    }


    void Walk(){
                triggerInteger = 0f;
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical")).normalized;

        if (move.magnitude >= 0.1f) //if were looking in any direction (i.e getting input to move)
        {

            //Rotating model
            float targetAngle = Mathf.Atan2(move.x, move.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, smoothTime);
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

            //Moving model
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * Time.deltaTime * playerSpeed);
            
            triggerInteger = 1.0f;
        }

        anim.SetFloat("speed", triggerInteger);
    }
    
    void TalkTo(Collider person){
        
        if (Input.GetKeyDown(KeyCode.E)){
            
            var stu = person.gameObject.GetComponent<StudentScript>();
            Debug.Log(stu.name);
            
        }
    }

   void PickUp(Collider temp){
        
        
        
        if (Input.GetKeyDown(KeyCode.E)){
            var item = temp.gameObject.GetComponent<Item>();
        
            inventory.AddItem(item.item);
            Destroy(temp.gameObject);
            
        }

       
    }

    
    IEnumerator Sprint(){
        
        if (Input.GetKeyDown("left shift")){
            anim.SetTrigger("sprint");
            playerSpeed = 7f;
            
        }
        else if (Input.GetKeyUp("left shift")){
            
            playerSpeed = 3f;
            anim.ResetTrigger("sprint");
        }
        
        yield return null;
    }

    // private void OnApplicationQuit() {
    //     inventory.Container.Clear();
    // }
}
