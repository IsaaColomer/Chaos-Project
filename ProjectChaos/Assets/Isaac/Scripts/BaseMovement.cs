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
        for(int i = 0; i < BuildingsManager.instance.buildings.Length; i++)
        {
            if(BuildingsManager.instance.buildings[i] != null)
            {
                agent.destination = BuildingsManager.instance.buildings[i].transform.position;
            }
        }
    }
}