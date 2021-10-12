using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateplayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            GetComponent<Animator>().SetTrigger("hatch");
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            GetComponent<Animator>().SetTrigger("idle");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<Animator>().SetTrigger("crackegg");
        }
    }
}
