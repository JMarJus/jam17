using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDirCopy : MonoBehaviour
{
    public Transform cam3D;
    public Transform cam2D;

    void Update()
    {
        if (cam3D.gameObject.active) transform.rotation = Quaternion.Euler(0, 0, 0);
        if (cam2D.gameObject.active) transform.rotation = Quaternion.Euler(0, 90, 0);
    }
}
