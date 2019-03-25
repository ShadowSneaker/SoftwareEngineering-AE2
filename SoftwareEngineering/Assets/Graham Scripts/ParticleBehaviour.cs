using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleBehaviour : MonoBehaviour {

    private float CurrentTime;
    
	// Use this for initialization
	void Start () {
        CurrentTime = 0;
        
	}
	
	// Update is called once per frame
	void Update () {
        CurrentTime += Time.deltaTime;
        if(CurrentTime >= 2)
        {
            Destroy(gameObject);
        }
	}
}
