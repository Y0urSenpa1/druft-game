using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dvigg : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject newObject;
    float speed = 0.1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        newObject.transform.Translate( new Vector3(-1,0,0)*Time.deltaTime);
    }
}
