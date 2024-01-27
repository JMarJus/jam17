using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    public GameObject cat;
    public GameObject npc;

    public GameObject imageBox;
    public GameObject catHUD;
    public GameObject textHUD;
    public TextMeshProUGUI textBox;
    public Image profile;
    private int currentMessage = 0;

    void Start()
    {
        NPCproperties CATproperties = cat.GetComponent<NPCproperties>();
    }

    void Update()
    {

    }

    void NextCandidate(GameObject npc)
    {
        NPCproperties NPCproperties = npc.GetComponent<NPCproperties>();
        profile.sprite = NPCproperties.face;
        List<string> messages = NPCproperties.messages;

        imageBox.SetActive(true);
        catHUD.SetActive(true);

        foreach (string message in messages)
        {
            if (currentMessage == 1)
            {
                catHUD.SetActive(false);
                textHUD.SetActive(true);
            }
            if (currentMessage > messages.Capacity - 1) EndInteraction();
            else if (currentMessage == messages.IndexOf(message)) textBox.text = message;
        }
        currentMessage++;
    }

    void EndInteraction()
    {
        textHUD.SetActive(false);
    }
}
