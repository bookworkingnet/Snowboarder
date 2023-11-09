using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public static int sceneIndex;
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", loadDelay);
        }
    }

    void ReloadScene()
    {
        if(sceneIndex > 2) {
    // Kết thúc game 
            return;
        }
        sceneIndex++;

        SceneManager.LoadScene(sceneIndex);
    }
}
