using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Player player;
    private Animator anim;
    
   
    void Start()
    {
        player = GetComponent<Player>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (player.direction.sqrMagnitude > 0) 
        {
            anim.SetInteger("transition", 1);
        }
        else
        {
            anim.SetInteger("transition", 0);
        }
        
    }
}