using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoToBase : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject finish;
    public bool goTo;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        finish = GameObject.FindGameObjectWithTag("Base1Road2");
        goTo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (goTo) Go();   
    }
    void Go()
    {
        agent.destination = finish.transform.position;
    }
}
