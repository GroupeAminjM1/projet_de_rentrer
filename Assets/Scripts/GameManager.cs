using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int tokenmanager = 0;
    public List<GameObject> l_canvas = new List<GameObject>(); 
    // Start is called before the first frame update
    void Start()
    {
        l_canvas[0].SetActive(true);
        for (int i = 1; i < 5; i++)
        {
            l_canvas[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
