using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateScore : MonoBehaviour
{
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "0";
 
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void SetScoreValue(int score)
    {
        ScoreText.text = score.ToString();
    }
}
