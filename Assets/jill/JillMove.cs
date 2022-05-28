using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JillMove : MonoBehaviour
{
  public Transform Player;
     int MoveSpeed = 4;
 public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Vector3.Distance(transform.position, Player.position)<=10&&Vector3.Distance(transform.position, Player.position)>1.5){
            transform.LookAt(Player);
         transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            animator.SetBool("isRun",true);
             animator.SetBool("isAttack",false);
          if (Vector3.Distance(transform.position, Player.position) <= 2)
             {
                  animator.SetBool("isRun",false);
                  animator.SetBool("isAttack",true);
                 //Here isAttack Call any function U want Like Shoot at here or something
             }
        }
 
        //  if (Vector3.Distance(transform.position, Player.position) >= 1)
        //  {
 
        //      transform.position += transform.forward * MoveSpeed * Time.deltaTime;
 
 
        //      //transform.position += transform.forward * MoveSpeed * Time.deltaTime;  
 
            
 
        //  }
    }
}
