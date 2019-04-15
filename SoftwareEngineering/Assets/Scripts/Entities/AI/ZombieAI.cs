using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieAI : MonoBehaviour
{
    // the three nodes the zombies will follow
    public GameObject TheNode1;
    public GameObject TheNode2;
    public GameObject TheNode3;

    // the players transform
    private Transform PlayerTransform;

    //nav mesht the AI will be walking on
    private NavMeshAgent TheNavMesh;

    // node zero is there to cancel out the normal movement when the zombie comes close to the player
    enum Node {Node1, Node2, Node3, Node0 };

    Node ZombiesNode;


	void Start ()
    {
        TheNavMesh = FindObjectOfType<NavMeshAgent>();
        ZombiesNode = Node.Node1;
	}

    void Update()
    {
     
        switch(ZombiesNode)
        {
            case (Node.Node1):
                {
                    Debug.Log("Moving to Node 2");
                    TheNavMesh.SetDestination(TheNode2.transform.position);

                    break;
                }
            case (Node.Node2):
                {
                    Debug.Log("Moving to Node 3");
                    TheNavMesh.SetDestination(TheNode3.transform.position);

                    break;
                }
            case (Node.Node3):
                {
                    Debug.Log("Moving to Node 1");
                    TheNavMesh.SetDestination(TheNode1.transform.position);

                    break;
                }
                case(Node.Node0):
                {
                    Debug.Log("Moving to Player");
                    TheNavMesh.SetDestination(PlayerTransform.position);

                    break;
                }

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Zombie Node 1")
        {
            Debug.Log("Hit Zombie Node 1");
            ZombiesNode = Node.Node1;
        }
        else if (other.name == "Zombie Node 2")
        {
            Debug.Log("Hit Zombie Node 2");
            ZombiesNode = Node.Node2;
        }
        else if (other.name == "Zombie Node 3")
        {
            Debug.Log("Hit Zombie Node 3");
            ZombiesNode = Node.Node3;
        }
        else if(other.name == "PlayerHitBox")
        {
            Debug.Log("Hit Player Node");
            ZombiesNode = Node.Node0;
            TheNavMesh.SetDestination(other.transform.position);
            PlayerTransform = other.transform;
        }

    }


    private void OnTriggerExit(Collider other)
    {
         if(other.name == "PlayerHitBox")
         {
            ZombiesNode = Node.Node1;
         }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Player Entity")
        {
            collision.gameObject.GetComponent<EntityScript>().ApplyDamage(1);
            Debug.Log("Hit");
        }
    }



}
