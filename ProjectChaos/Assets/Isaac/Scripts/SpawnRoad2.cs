using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRoad2 : MonoBehaviour
{
    public GameObject troop1;
    public float time0;
    private float time2;
    // Start is called before the first frame update
    void Start()
    {
        time2 = time0;   
    }

    // Update is called once per frame
    void Update()
    {
        CountDown();
    }

    void CountDown()
    {
        time0 -= Time.deltaTime;
        if(time0<0.0f)
        {
            time0 = time2;
            Instantiate(troop1, transform.position, Quaternion.identity);
        }
    }
}
