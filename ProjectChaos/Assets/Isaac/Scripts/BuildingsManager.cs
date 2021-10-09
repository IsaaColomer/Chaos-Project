using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsManager : MonoBehaviour
{
    public static BuildingsManager instance;
    [Tooltip("Left Base")]
    public GameObject buildingsRoad1;
    [Tooltip("Background Base")]
    public GameObject buildingsRoad2;
    [Tooltip("Right Base")]
    public GameObject buildingsRoad3;
    [Tooltip("Main Base")]
    public GameObject buildingsRoad4;
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
