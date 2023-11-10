using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class car : MonoBehaviour
{
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = GetDestination();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance < 1)
        {
            agent.destination = GetDestination();
        }
        
    }
    public Vector3 GetDestination()
    {
        int dest = Random.Range(1, 19);
        return GameObject.Find("Point" + dest).transform.position;
    }
}
