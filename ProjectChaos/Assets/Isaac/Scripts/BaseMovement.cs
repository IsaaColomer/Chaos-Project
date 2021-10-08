using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEditor.AI;

public class BaseMovement : MonoBehaviour
{
    public static BaseMovement instance;
    private NavMeshAgent agent;
    private Rigidbody rb;
    public int type;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        agent = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}