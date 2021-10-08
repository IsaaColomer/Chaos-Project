using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsManager : MonoBehaviour
{
    public static BuildingsManager instance;
    public GameObject[] buildingsRoad1;
    public GameObject[] buildingsRoad2;
    public GameObject[] buildingsRoad3;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
