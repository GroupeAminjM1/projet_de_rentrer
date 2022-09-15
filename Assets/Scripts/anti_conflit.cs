using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anti_conflit : MonoBehaviour
{ public GameObject pop;
    public List<GameObject> bat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        foreach( GameObject obj in bat) {
            if (pop.activeSelf)
            {
                obj.SetActive(false);
            }
            else
            {
                obj.SetActive(true);
            }

        }
    }

}
