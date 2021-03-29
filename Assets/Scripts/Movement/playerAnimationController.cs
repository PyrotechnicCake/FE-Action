using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimationController : MonoBehaviour
{
    //animations and shitre
    //public GameObject myArma;
    public Animator anim;
    public CharacterController player;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxisRaw("Horizontal") != 0) || (Input.GetAxisRaw("Vertical") != 0))
        {
            if (player.isGrounded == true)
            {
                //animate walk
                anim.Play("Walk01");
            }
        }
        else
        {
            if (player.isGrounded == true)
            {
                anim.Play("Idle01");
            }
        }

        //is player in air
        if (player.isGrounded == false)
        {
            anim.Play("jumpair");
        }
    }
}