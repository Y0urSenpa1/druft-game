using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquadDvig : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject Squaddd;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Squaddd.transform.Translate(new Vector3(20,-20,0) * Time.deltaTime);
    }
}
