using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMe : MonoBehaviour
{
    public static DeleteMe instance;
    public GameObject dp;
    public int d;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        d = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(d >= 1)
        {
            dp.SetActive(false);
            Destroy(dp.gameObject);
        }
    }
}
