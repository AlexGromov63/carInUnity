using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 20.0f;
    public float turnspeed = 10.0f;
    // Update is called once per frame
    void Update()
    {
        var HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up * Time.deltaTime * turnspeed * HorizontalInput);
    }
}
