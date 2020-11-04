using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuelScript : MonoBehaviour
{
    public float fuelUsed;
    public float maxFuel;

    [SerializeField] Image fuelBar;
    

    // Start is called before the first frame update
    void Start()
    {
        fuelBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(fuelBar.fillAmount > 0)
            fuelBar.fillAmount -= fuelUsed * Time.deltaTime/maxFuel;
        else
            Debug.Log("Game Over");
    }

    public void setFuel(float fuel)
    {       
        fuelBar.fillAmount += fuel;
    }

}
