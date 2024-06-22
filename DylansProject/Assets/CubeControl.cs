using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    float CubeSpeed = 20f;
    bool CanTurbo = true;
    float RotateSpeed = 120f;
    public AudioSource audioPlayer;

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

        if (Input.GetKey(KeyCode.LeftShift))
        {
            StartCoroutine(TurboBoostFunction());
        }
        
        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.H)) 
        {
            transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.T)) 
        {
            transform.Rotate(Vector3.right * RotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.G)) 
        {
            transform.Rotate(-Vector3.right * RotateSpeed * Time.deltaTime);
        }
    }

    public IEnumerator TurboBoostFunction() {
        print("Boost");
        if (CanTurbo == true) {
            CanTurbo = false;
            audioPlayer.Play();
            CubeSpeed = 300f;
            yield return new WaitForSeconds(6);
            CubeSpeed = 20f;
            yield return new WaitForSeconds(6);
            CanTurbo = true;
            }
    }
}
