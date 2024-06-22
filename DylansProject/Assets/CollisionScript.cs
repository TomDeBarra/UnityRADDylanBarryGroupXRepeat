using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour
{   
    FadeInOut fade;
    public Renderer rend;
    bool entered;

    public AudioSource audioPlayer;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            print("Entered");
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            if(entered != true){
            entered = true;
            StartCoroutine(_CollisionScript());
            }
            
        }
    }
    
    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Debug.Log("Exit");
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;

        fade = FindObjectOfType<FadeInOut>();
    }

    public IEnumerator _CollisionScript()
    {   
        fade.FadeIn();
        audioPlayer.Play();

        yield return new WaitForSeconds(6);
        Application.Quit();
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif            
    }

}
