using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateComponent : MonoBehaviour
{
    public float speed;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0 , 10 * speed , 0);
    }
}
