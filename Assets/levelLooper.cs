using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelLooper : MonoBehaviour
{
    public GameObject lvlPrefab;
    public GameObject backLvl, midLvl, frontLvl;
    
    Vector3 playerPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = transform.parent.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Level")
        {            
            frontLvl = Instantiate(lvlPrefab, new Vector3(0, 0, playerPos.z) + new Vector3(0,0,380), lvlPrefab.transform.rotation);
            Destroy(backLvl);
            backLvl = midLvl;
            midLvl = frontLvl;
        }
    }
}
