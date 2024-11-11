using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMover : MonoBehaviour
{
    private Vector3 target;
    private Camera cam;
    private Animator animator;
    private NavMeshAgent agent;

    private void Start()
    {
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            target = GetMouseWorldPos();
            
            if (agent != null && target != Vector3.negativeInfinity) 
                agent.SetDestination(target);
        }
    }

    private Vector3 GetMouseWorldPos()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out var hit)) return hit.point;
        else return Vector3.negativeInfinity;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Die"))
        {
            animator.SetBool("die", true);
        }

        if (other.CompareTag("Attack"))
        {
            animator.SetTrigger("attack");
        }
    }
}