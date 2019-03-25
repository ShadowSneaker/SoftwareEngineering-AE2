using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObjects : MonoBehaviour {

    public GameObject Particles;
    public bool Thrown;


	// Use this for initialization
	void Start () {
        Thrown = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Thrown)
        {
            GetComponent<Rigidbody>().isKinematic = false;         
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (Thrown)
        {
            Break();
        }
    }
    private void Break()
    {
        Instantiate(Particles, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
