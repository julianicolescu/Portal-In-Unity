using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyRotation : MonoBehaviour
{
    public Transform theObject;
    public Transform target;

    public bool rotateOnlyY;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateOnlyY)
        theObject.eulerAngles = new Vector3 (theObject.eulerAngles.x, target.eulerAngles.y, theObject.eulerAngles.z);

        else
        theObject.eulerAngles = target.eulerAngles;
    }
}
