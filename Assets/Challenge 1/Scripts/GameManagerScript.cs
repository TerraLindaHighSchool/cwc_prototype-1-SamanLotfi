using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public int count { get; set; }
    public TextMeshProUGUI countText;
    public GameObject winText;

    // Start is called before the first frame update
    public void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        Debug.Log(count);
        if (count >= 23)
        {
            winText.SetActive(true);
        }
    }
}
