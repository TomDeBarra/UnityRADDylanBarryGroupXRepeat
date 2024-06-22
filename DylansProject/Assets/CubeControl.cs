using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    float CubeSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
        transform.position += CubeSpeed * Vector3.up * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
        transform.position += CubeSpeed * Vector3.down * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
        transform.position += CubeSpeed * Vector3.right * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
        transform.position += CubeSpeed * Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
        transform.position += CubeSpeed * Vector3.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
        transform.position -= CubeSpeed * Vector3.forward * Time.deltaTime;
        }
    }
}
