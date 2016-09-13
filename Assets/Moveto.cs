using UnityEngine;
using System.Collections;

public class Moveto : MonoBehaviour {

    // Use this for initialization
    public Transform goal;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }

    // Update is called once per frame
    void Update () {
	
	}
    void OnCollisionExit(Collision collision)
    {
        agent.destination = goal.position;
    }

}
