using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    public Transform theObject;
    public Transform target;

    void Start()
    {
        
    }

    
    void Update()
    {
        theObject.position = target.position;
    }
}
