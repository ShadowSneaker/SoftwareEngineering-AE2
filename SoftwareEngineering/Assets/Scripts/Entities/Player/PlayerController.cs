using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    // The direction the player should move in.
    private Vector3 MoveDir;
    
    
    
    // A reference to the attached PlayerScript component.
    PlayerScript Player;


    //the Image pannel for the pause menu and inventory menu
    public Image PauseMenu;
    public Image Inventory;

    private void Start()
    {
        Player = GetComponent<PlayerScript>();

    }


    private void FixedUpdate()
    {
        MoveDir = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        MoveDir = transform.TransformDirection(MoveDir);

        if (Input.GetButton("Jump"))
        {
            //Player.Jump();
        }

        Player.MoveDirection(MoveDir);


        // byrons code
        if(Input.GetButton("Pause Menu"))
        {
            PauseMenu.gameObject.SetActive(!PauseMenu.IsActive());
        }


        if(Input.GetButton("Inventory"))
        {
            Inventory.gameObject.SetActive(!Inventory.IsActive());
        }
    }

}
