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
    TimeHandle times;
    public bool walk;

    // Start is called before the first frame update
    void Start()
    {
        health = 50;
        //instance = this;
        agent = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
        walk = true;
    }

    // Update is called once per frame
    void Update()
    {

        switch(type)
        {
            case 1:
                agent.destination = BuildingsManager.instance.buildingsRoad1.gameObject.transform.GetChild(0).transform.position;
                break;
            case 2:
                agent.destination = BuildingsManager.instance.buildingsRoad2.gameObject.transform.GetChild(0).transform.position;
                break;
            case 3:
                agent.destination = BuildingsManager.instance.buildingsRoad3.gameObject.transform.GetChild(0).transform.position;
                break;
            case 4:
                agent.destination = BuildingsManager.instance.buildingsRoad4.gameObject.transform.GetChild(0).transform.position;
                break;
        }
    
        //Movement
        
        //Health
        //health -= Time.deltaTime;
        if (health <= 0) Die();
        
    }
    void Die()
    {
        Destroy(this.gameObject);
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag != this.gameObject.tag)
        {
            //FIGHT!!
            rb.velocity = Vector3.zero;
            agent.velocity = Vector3.zero;
            

            Attack(other.gameObject);

            
        }
        
    }
    private void Attack(GameObject enemy)
    {
        //if(T)
        enemy.GetComponent<Troop>().health -= 1;

    }

}
