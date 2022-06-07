using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public int count { get; set; }
    public TextMeshProUGUI countText;
    public GameObject winText;

    public void start()
    {
        count = 0;
        winText.SetActive(false);
    }

    public void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        
        if (count >= 23)
        {
            winText.SetActive(true);
        }
    }
}
