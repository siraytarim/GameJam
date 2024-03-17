using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wayPoint : MonoBehaviour
{

    public Transform[] waypoints; // Waypoint'lerin listesi
    public float speed = 2.0f; // Nesnenin hýzý
    public int currentWaypointIndex = 0;

//    public GameObject sonküp;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    bool esit = false;
    void Update()
    {
        // Nesnenin waypoint'e olan uzaklýðýný hesaplayýn
        float distanceToWaypoint = Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position);

        // Nesne waypoint'e yeterince yakýnsa
        if (distanceToWaypoint < 0.1f)
        {
            // Bir sonraki waypoint'e geçin
            currentWaypointIndex++;

            // Eðer son waypoint'e ulaþtýysanýz, baþa dönün
            if (currentWaypointIndex >= waypoints.Length)
            {
                Destroy(gameObject);
            }
        }

        // Nesneyi waypoint'e doðru hareket ettirin
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "karanlýk")
        {
            anim.SetTrigger("Play");
        }
    }
}
