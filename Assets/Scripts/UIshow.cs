using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIshow : MonoBehaviour
{
    public Canvas UI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (UI.gameObject.active) UI.gameObject.SetActive(false);
            else UI.gameObject.SetActive(true);
        }
    }
}
