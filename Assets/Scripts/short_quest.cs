using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class short_quest : MonoBehaviour
{
    public int compteur = 0;
    public bool v1, v2 = false;
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

    public void increment1()
    {
        if (v1 == false) { compteur++; v1 = true; }
        
    }
    public void increment2()
    {
        if (v2 == false) { compteur++; v2 = true; }
    }
}

