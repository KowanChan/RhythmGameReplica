using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreLayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
