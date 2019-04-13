using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    // a queue of sentences that the NPC will iterate through for option one
    private Queue<string> SentencesOne;
    // a queue of sentences that the NPC will iterate through for option two
    private Queue<string> SentencesTwo;
    // a queue of sentences that the NPC will iterate through for the event 
    private Queue<string> SentencesEvent;

    // public buttons
    //public Button SkipText;
    //public Button EndText;

    // text used for the dialog
    public Text CharecterText;
    //public Dialogue NPCDialogue;


    //image for the dialog pannel
    public Image DialogPanel;
    

    // bool to tell when the corutine is running
    private bool CR_Running;

    //timer
    //private float Timer = 1;

    ////
    //public bool beginingDialog;
    //// finsih the dialog
    //public bool EndDialog;

    //bools to determine which dialog needs to be displayed
    public bool dialogone;
    public bool dialogtwo;
    public bool dialogevent;

    // buttons for the choices when the player starts dialogue
    public Image ChoiceOne;
    public Image ChoiceTwo;
    public Image ChoiceEvent;

    //sentence that the display sentence is displayed in
    private string sentence;

    void Start ()
    {
        SentencesOne = new Queue<string>();
        SentencesTwo = new Queue<string>();
        SentencesEvent = new Queue<string>();
        //CharecterText.gameObject.SetActive(false);

        DialogPanel.gameObject.SetActive(false);

        ChoiceOne.gameObject.SetActive(true);
        ChoiceTwo.gameObject.SetActive(true);
        ChoiceEvent.gameObject.SetActive(true);
        //beginingDialog = true;
    }


     //void Update()
     //{
     //   if (!EndDialog)
     //   {
     //       if (!beginingDialog)
     //       {
     //           if (CR_Running)
     //           {
     //
     //           }
     //           else
     //           {
     //               if (Sentences.Count == 0)
     //               {
     //                   Debug.Log("Entering last line ");
     //                   StartCoroutine(TypeWriter(NPCDialogue.FinalLine));
     //                  
     //                   EndDialog = true;
     //                   //CharecterText.gameObject.SetActive(false);
     //               }
     //               else
     //               {
     //                   StartCoroutine(TypeWriter(Sentences.Dequeue()));
     //                   
     //               }
     //           }
     //       }
     //   }
     //}


    //public void Dialog()
    //{
    //    beginingDialog = true;
    //    gameObject.GetComponent<NPC>().interactPlayer = true;
    //    if (beginingDialog)
    //    {
    //        CharecterText.gameObject.SetActive(true);
    //
    //        foreach(string sentence in NPCDialogue.sentences)
    //        {
    //            Sentences.Enqueue(sentence);
    //        }
    //
    //        StartCoroutine(TypeWriter(NPCDialogue.StartLine));
    //    }
    //
    //    EndDialog = false;
    //    
    //}

    public void StartDialog(Dialogue OptionOneDialogue, Dialogue OptionTwoDialog, Dialogue OptionEventDialog)
    {
        Cursor.visible = !Cursor.visible;
        Debug.Log("starting conversation");

        //to check to make sure they are all empty 
        SentencesOne.Clear();
        SentencesTwo.Clear();
        SentencesEvent.Clear();

        //stores all of the sentnces within the 
        foreach(string sentence in OptionOneDialogue.sentences)
        {
            SentencesOne.Enqueue(sentence);
        }

        foreach(string sentence in OptionTwoDialog.sentences)
        {
            SentencesTwo.Enqueue(sentence);
        }

        foreach(string sentence in OptionEventDialog.sentences)
        {
            SentencesEvent.Enqueue(sentence);
        }


        DialogPanel.gameObject.SetActive(true);


    }


    public void DisplayNextSentence()
    {
        if(SentencesOne.Count == 0 || SentencesTwo.Count == 0 || SentencesEvent.Count == 0)
        {
            EndMainDialog();
            return;
        }

        

        if (dialogone)
        {
             sentence = SentencesOne.Dequeue();
        }
        else if (dialogtwo)
        {
             sentence = SentencesTwo.Dequeue();
        }
        else if(dialogevent)
        {
            sentence = SentencesEvent.Dequeue();
        }

        //display it to the screen
        StartCoroutine(TypeWriter(sentence));
        

    }

    public void EndMainDialog()
    {
        Cursor.visible = !Cursor.visible;
        Debug.Log("end of converstaion");
        DialogPanel.gameObject.SetActive(false);
    }

    public void PickDialog(int dialog)
    {
        if(dialog == 1)
        {
            dialogone = true;
            ChoiceOne.gameObject.SetActive(false);
            ChoiceTwo.gameObject.SetActive(false);
            ChoiceEvent.gameObject.SetActive(false);
        }
        else if (dialog == 2)
        {
            dialogtwo = true;
            ChoiceOne.gameObject.SetActive(false);
            ChoiceTwo.gameObject.SetActive(false);
            ChoiceEvent.gameObject.SetActive(false);
        }
        else if (dialog == 3)
        {
            dialogevent = true;
            ChoiceOne.gameObject.SetActive(false);
            ChoiceTwo.gameObject.SetActive(false);
            ChoiceEvent.gameObject.SetActive(false);
        }
    }



    IEnumerator TypeWriter(string line)
    {
        

        CR_Running = true;

        CharecterText.text = "";

        foreach(char letter in line.ToCharArray())
        {
            CharecterText.text += letter;
            
            yield return new WaitForSeconds(0.2f);
        }

        CR_Running = false;

        //if (beginingDialog)
        //{
        //    beginingDialog = false;
        //}


        //if(EndDialog)
        //{
        //    CharecterText.gameObject.SetActive(false);
        //    gameObject.GetComponent<NPC>().interactPlayer = false;
        //}
    }

  

}
