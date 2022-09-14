using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class short_quest : MonoBehaviour
{
    public int compteur = 0;
    public TMPro.TextMeshProUGUI count;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count.text = "X " + compteur;

       

    }

    public void increment()
    {
        compteur++;
    }
}
