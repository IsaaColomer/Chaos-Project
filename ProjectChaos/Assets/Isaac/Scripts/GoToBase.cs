using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEditor.AI;

public class GoToBase : MonoBehaviour
{
    public static GoToBase instance;
    private NavMeshAgent agent;
    private GameObject finish;
    private GameObject finish2;
    public bool goTo;
    public bool cock;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        agent = GetComponent<NavMeshAgent>();
        finish = GameObject.FindGameObjectWithTag("Base1Road2");
        finish2 = GameObject.FindGameObjectWithTag("2");
        rb = GetComponent<Rigidbody>();
        goTo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (goTo) Go();
        if (!goTo) Goes();

        if (finish.activeSelf == false) goTo = false;
    }
    void Go()
    {
        agent.destination = finish.transform.position;
    }
    void Goes()
    {
        agent.destination = finish2.transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Cum")) goTo = false;
        DeleteMe.instance.d++;
    }
}