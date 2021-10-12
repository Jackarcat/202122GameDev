using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.Translate(0.002f, 0.002f, 0f);
        //gameObject.transform.localScale += new Vector3(0.2f,0.2f,0);

        gameObject.transform.Translate(0 , Input.GetAxis("Vertical") * 0.01f , 0);
        gameObject.transform.Rotate(0, 0, Input.GetAxis("Horizontal") * -0.2f);

        //Input.GetAxis("Horizontal"));
    }
}
