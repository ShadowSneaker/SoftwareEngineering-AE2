using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    // this allows us to modify the dialogue
    public Dialogue OptionOnedialogue;
    public Dialogue OptionTwodialogue;
    public Dialogue Eventdialogue;


    // whent the player interacts with the NPC it triggers the dialogusign this function
    public void TriggerDialog()
    {
        FindObjectOfType<DialogueManager>().StartDialog(OptionOnedialogue, OptionTwodialogue, Eventdialogue);
       // FindObjectOfType<DialogueManager>().StartDialog(dialogue);
    }


}
