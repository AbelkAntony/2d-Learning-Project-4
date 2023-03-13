using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateLife : MonoBehaviour
{
    public Text LifeCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetLifeValue(int value)
    {
        LifeCount.text = value.ToString();
    }
}
