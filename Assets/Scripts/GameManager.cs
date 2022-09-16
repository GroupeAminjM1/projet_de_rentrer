using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public short_quest quest_token;
    public TMPro.TextMeshProUGUI recomp_token;
    public GameObject recomp_diplome;
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

    public void Refreshtoken()
    {
        recomp_token.text = ""+tokenmanager;
    }

    // Update is called once per frame
    void Update()
    {
        tokenmanager = quest_token.compteur;
        if (quest_token.endQ1 == true && quest_token.endQ2 == true && quest_token.endQ3 == true)
        {
            recomp_diplome.SetActive(true);
        }


    }
}
