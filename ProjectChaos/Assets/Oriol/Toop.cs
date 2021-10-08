using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEditor.AI;

public class Toop : MonoBehaviour
{
    public TroopManager Manager;
    
    //public static Toop instance;
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
            for(int i = 0; i < BuildingsManager.instance.buildingsRoad1.Length; i++)
            {
                if(BuildingsManager.instance.buildingsRoad1[i] != null)
                {
                    agent.destination = BuildingsManager.instance.buildingsRoad1[i].transform.position;
                }
            } 
        }
        else if(type == 2)
        {
            for(int i = 0; i < BuildingsManager.instance.buildingsRoad2.Length; i++)
            {
                if(BuildingsManager.instance.buildingsRoad2[i] != null)
                {
                    agent.destination = BuildingsManager.instance.buildingsRoad2[i].transform.position;
                }
            }
        }
        else if(type == 3)
        {
            for(int i = 0; i < BuildingsManager.instance.buildingsRoad3.Length; i++)
            {
                if(BuildingsManager.instance.buildingsRoad3[i] != null)
                {
                    agent.destination = BuildingsManager.instance.buildingsRoad3[i].transform.position;
                }
            }
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
