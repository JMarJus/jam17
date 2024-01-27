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
    List<string> messages;
    private int currentMessage = 0;

    bool interacting = false;

    void Start()
    {
        NPCproperties CATproperties = cat.GetComponent<NPCproperties>();
    }

    void Update()
    {
        if (interacting && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Interact();
        }
    }

    public void NextCandidate(GameObject npc)
    {
        NPCproperties NPCproperties = npc.GetComponent<NPCproperties>();
        profile.sprite = NPCproperties.face;

        imageBox.SetActive(true);
        catHUD.SetActive(true);

        interacting = true;
        messages = NPCproperties.messages;
        Interact();
    }

    void Interact()
    {
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
        interacting = false;
        textHUD.SetActive(false);
    }
}
