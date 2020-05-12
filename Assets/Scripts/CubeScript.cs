using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Disable the behaviour when it becomes invisible...
    void OnBecameInvisible()
    {
        Debug.Log("invisible");
        enabled = false;
    }

    // ...and enable it again when it becomes visible.
    void OnBecameVisible()
    {
        Debug.Log("visible");
        enabled = true;
    }
}
