using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop_Up_manager : MonoBehaviour
{
    public TMPro.TextMeshProUGUI hello;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Multimedia_P()
    {
        hello.text = "ceci est le batiment multimedia";
    }

    public void Administration_P()
    {
        hello.text = "ceci est le batiment Administration";
    }

    public void ElisaLemonier_P()
    {
        hello.text = "ceci est le batiment elisa bidule";
    }
}
