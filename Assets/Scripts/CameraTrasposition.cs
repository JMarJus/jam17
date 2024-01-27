using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrasposition : MonoBehaviour
{
    public Transform cam3D;
    public Transform cam2D;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Mode3D();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Mode2D();
        }
    }

    void Mode3D()
    {
        cam3D.gameObject.SetActive(true);
        cam2D.gameObject.SetActive(false);
    }

    void Mode2D()
    {
        cam2D.gameObject.SetActive(true);
        cam3D.gameObject.SetActive(false);
    }
}
