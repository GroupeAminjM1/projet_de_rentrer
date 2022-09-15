using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class short_quest : MonoBehaviour
{
    public int compteur = 0;
    public bool endQ1, endQ2, endQ3, 
                    clickAdmin, clickMulti1, clickMulti2, clickMulti3,
                        clickAmbic1, clickEB2, clickEB3,
                            clickJJ2, clickJJ3,
                                clickRU2, clickCafet2, clickBU3 = false;
    public int flag1, flag2 = 0;
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

    public void endQuest1()
    {
        if ((endQ1 == false) && (clickAdmin == true) && (clickAmbic1 == true) && (clickMulti1 == true)) { compteur++; endQ1 = true; }
    }

    public void endQuest2()
    {
        if ((endQ2 == false) && (clickAdmin == true) && (clickEB2 == true) && (clickMulti2 == true)
                                && (clickJJ2 == true) && (clickRU2 == true) && (clickCafet2)) { compteur++; endQ2 = true; }
    }

    public void endQuest3()
    {
        if ((endQ3 == false) && (clickAdmin == true) && (clickJJ3 == true) && (clickMulti3 == true)
                                && (clickEB3 == true) && (clickBU3)) { compteur++; endQ3 = true; }
    }

    //-------------------------------------------------------------------------------------------------------------------------------

    public void incAdmin()
    {
        if ((clickAdmin == false) && (flag1 == 0) && (flag2 == 0)) { flag1++; flag2++; clickAdmin = true; }
    }

    public void incMulti()
    {
        if ((clickMulti1 == false) && (flag1 == 1)) { flag1++; clickMulti1 = true; }
        if ((clickMulti2 == false) && (flag2 == 2)) { flag2++; clickMulti2 = true; }
        if (clickMulti3 == false) {clickMulti3 = true; }
    }

    public void incAmbic()
    {
        if ((clickAmbic1 == false) && (flag1 == 2)) { clickAmbic1 = true; }
    }

    public void incEB()
    {
        if ((clickEB2 == false) && (flag2 == 1)) { flag2++; clickEB2 = true; }
        if (clickEB3 == false) { clickEB3 = true; }
    }

    public void incJJ()
    {
        if ((clickJJ2 == false) && (flag2 == 3)) { flag2++; clickJJ2 = true; }
        if (clickJJ3 == false) { clickJJ3 = true; }
    }

    public void incBU()
    {
        if (clickBU3 == false) { clickBU3 = true; }
    }

    public void incRU()
    {
        if ((clickRU2 == false) && (flag2 == 4)) { flag2++; clickRU2 = true; }
    }

    public void incCafet()
    {
        if ((clickCafet2 == false) && (flag2 == 5)) { clickCafet2 = true; }
    }
}

