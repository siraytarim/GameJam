using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class destination : MonoBehaviour
{
    [SerializeField] private GameObject destinationPoint;
    NavMeshAgent agent;

    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.SetDestination(destinationPoint.transform.position);

    }
}
