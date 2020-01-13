using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereResizer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // what should I put here?
        GameObject.Find("Sphere").transform.localScale = new Vector3(1f, 1f); 
    }

    // Update is called once per frame
    void Update()
    {
    }
}
