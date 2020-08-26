using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCubeLocation : MonoBehaviour

    
{

    public Vector3 CubePos;
    public Vector3 CubeScale;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = (CubePos);
        this.gameObject.transform.localScale = (CubeScale);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
