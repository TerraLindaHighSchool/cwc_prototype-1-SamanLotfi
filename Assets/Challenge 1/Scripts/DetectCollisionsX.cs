using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DetectCollisionsX : MonoBehaviour
{
    public GameManagerScript gameManagerScript;

    public void OnTriggerEnter(Collider other)
    { 

        if (other.gameObject.CompareTag("Carrot"))
        {

            gameManagerScript.count++;
            gameManagerScript.SetCountText();
            Destroy(other.gameObject);
            gameObject.SetActive(false);
        }
    }
}
