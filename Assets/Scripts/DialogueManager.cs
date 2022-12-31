using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject panelDialog;
    public TextMeshProUGUI dialog;
    public string[] message;
    public bool dialogStart = false;
    private bool KeyPress = true;

    void Start()
    {
        message[0] = "Ho-ho-ho!";
        message[1] = "Hi, I'm Santa. I need your help...";
        message[2] = "I have to deliver a lot of presents. And I can't do it alone";
        message[3] = "I turn you into the snowman. And give you 5 presents. You need to deliver them";
        panelDialog.SetActive(false);
        
    }
    private void OnTriggerEnter2D (Collider2D coll)
    {
        if(coll.tag == "Player")
        {
            panelDialog.SetActive(true);
            dialog.text = message[0];
            dialogStart = true;
        }
    }
    private void OnTriggerExit2D(Collider2D coll)
    {
        panelDialog.SetActive(false);
        dialogStart = false;
    }
    private void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            dialog.text = message[1];
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            dialog.text = message[2];
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            dialog.text = message[3];
        }
    }
}
