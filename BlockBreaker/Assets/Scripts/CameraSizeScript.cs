using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSizeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Camera>().orthographicSize = 6;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
