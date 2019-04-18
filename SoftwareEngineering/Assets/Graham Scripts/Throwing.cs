using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour {
    private bool active;
    private bool throwActive;
    public Vector3 holdingPosition;
    public float ThrowForce;
	// Use this for initialization
	void Start () {
        active = true;
        throwActive = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (throwActive == false)
        {
            if (GetComponent<ActivatableObject>().Activated == true)
            {
                throwActive = true;
                Destroy(GetComponent<ActivatableObject>());
                Destroy(GetComponent<InteractableObject>());
            }
        }
        {
            if (throwActive == true)
            {
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                if (active == true)
                {
                    GameObject Player = GameObject.FindGameObjectWithTag("Player");
                    transform.parent = Player.transform;

                    active = false;
                }
                transform.localPosition = holdingPosition;
            }
        }
        if (throwActive)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GetComponent<BreakableObjects>().Thrown = true;
                transform.parent = null;
                gameObject.GetComponent<Rigidbody>().velocity = transform.forward * ThrowForce;
                Destroy(GetComponent<Throwing>());
            }
        }
	}
}
