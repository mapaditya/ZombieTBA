using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float score;
    Text scoreUI;
    GameObject endPanel;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreUI = GameObject.Find ("Score").GetComponent<Text> ();
        endPanel = GameObject.Find("GameOver");
        endPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        TampilkanScore ();
    }

    void TampilkanScore () {
        scoreUI.text = score + "";
    }
}
