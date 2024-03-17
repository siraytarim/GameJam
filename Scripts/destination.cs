using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class destination : MonoBehaviour
{
    [SerializeField] private GameObject destinationPoint;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(destinationPoint.transform.position);

    }
}
