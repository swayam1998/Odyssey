using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathRayController : MonoBehaviour
{
    public GameObject deathRay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            deathRay = Instantiate(deathRay, transform.position, transform.rotation);
            deathRay.transform.position = transform.position;

        }
    }
}
