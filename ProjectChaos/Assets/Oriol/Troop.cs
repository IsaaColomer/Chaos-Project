using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Troop : MonoBehaviour
{
    private NavMeshAgent agent;
    private Rigidbody rb;

    public float health;
    public float speed;
    public int type;

    // Start is called before the first frame update
    void Start()
    {
        health = 50;
        //instance = this;
        agent = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        if(type == 1)
        {
            agent.destination = BuildingsManager.instance.buildingsRoad1.gameObject.transform.GetChild(0).transform.position;
        }
        else if(type == 2)
        {
            agent.destination = BuildingsManager.instance.buildingsRoad2.gameObject.transform.GetChild(0).transform.position;
        }
        else if(type == 3)
        {
            agent.destination = BuildingsManager.instance.buildingsRoad3.gameObject.transform.GetChild(0).transform.position;
        }
        //Health
        health -= Time.deltaTime;
        if (health <= 0) Die();
        
    }
    void Die()
    {
        Destroy(this.gameObject);
    }

}
