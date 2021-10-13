using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopManager : MonoBehaviour
{
    public static TroopManager instance;
    
    public int type; 
    public GameObject troop1;
    public float time0;
    private float time2;
    public Transform acum;
 
    // Start is called before the first frame update
    void Start()
    {
        time2 = time0;
        instance = this;
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
            troop1.GetComponent<Troop>().type = type;
            GameObject go = Instantiate(troop1, transform.position, Quaternion.identity, acum);

            if (this.gameObject.layer == LayerMask.NameToLayer("SpawnerBase1"))
            {
                go.gameObject.tag = "EnemyBase1";
            }
            else if(this.gameObject.layer == LayerMask.NameToLayer("SpawnerBase2"))
            {
                go.gameObject.tag = "EnemyBase2";
            }
            else if (this.gameObject.layer == LayerMask.NameToLayer("SpawnerBase3"))
            {
                go.gameObject.tag = "EnemyBase3";
            }
            else if (this.gameObject.layer == LayerMask.NameToLayer("SpawnerBase4"))
            {
                go.gameObject.tag = "EnemyBase4";
            }

            time0 = time2;
        }
    }
}
