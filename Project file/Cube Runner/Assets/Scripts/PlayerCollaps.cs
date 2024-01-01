using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollaps : MonoBehaviour
{
    public PlayerScript playerScript;
    public Score score;
    public GameController GameController;
    public AudioSource audioSource;
    public AudioSource audioSource1;

    private void OnTriggerEnter(Collider other)

    {
        {
            if (other.gameObject.tag == "Collectable")
            {
                audioSource.Play();
                score.AddScore(1);
                Destroy(other.gameObject);
            } 
        }  
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Obstracles")
        {
            audioSource1.Play();
            GameController.GameOver();
            playerScript.enabled = false;
        }
    }

}
