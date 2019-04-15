using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayNotestext : MonoBehaviour {


    public GameObject Text;
    public string NoteText;
    private bool InteractingWith;
	// Use this for initialization
	void Start () {
        InteractingWith = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<ActivatableObject>().Activated == true)
        {
            Text.GetComponent<Text>().enabled = true;
            Text.GetComponent<Text>().text = NoteText;
            InteractingWith = true;
        }
        else if(InteractingWith && GetComponent<ActivatableObject>().Activated ==false)
        {
            InteractingWith = false;
            Text.GetComponent<Text>().enabled = false;
            Text.GetComponent<Text>().text = " ";
        }
	}
    
}
