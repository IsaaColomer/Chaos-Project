using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTroopLife : MonoBehaviour
{
    public static BasicTroopLife instance;
    public float hp;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        hp -= Time.deltaTime;
        if (hp <= 0) Die();
    }
    
    void Die()
    {
        Destroy(this.gameObject);
    }
}
