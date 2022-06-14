using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class NewBehaviourScript : MonoBehaviour
{


   private UnityEngine.AI.NavMeshAgent pathfinder;
   public Transform target;
    
    void Start()
    {
        pathfinder = GetComponent<UnityEngine.AI.NavMeshAgent>();
        target = GameObject.Find("insert whatever the object you want to follow is ").transform;

    }

    void Update()
    {
        pathfinder.SetDestination(target.position);

        
    }


}
