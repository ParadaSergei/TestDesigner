using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class WalkingBehaviour : StateMachineBehaviour
{
    List<Transform> point = new List<Transform>();
    NavMeshAgent police;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Transform pointsObject = GameObject.FindGameObjectWithTag("Points").transform;
        foreach (Transform _points in pointsObject)
        {
            point.Add(_points);
        }
        police = animator.GetComponent<NavMeshAgent>();
        police.speed = 3;
    }
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (countPoint.numberPoint == 4)
            countPoint.numberPoint = 0;
        if (police.remainingDistance <= police.stoppingDistance)
        {
            police.SetDestination(point[countPoint.numberPoint].position);
            countPoint.numberPoint++;
            if (point[1])
            {
                animator.SetBool("isWalking", false);
                animator.SetBool("isRun", true);
            }
            else if (point[3])
            {
                animator.SetBool("isWalking", false);
                animator.SetBool("isRun", true);
            }
        }
    }
}
