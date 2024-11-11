using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour
{
    [SerializeField] private Transform rightHandTarget;
    [SerializeField] private float lerpSpeed = 10f;
    private Vector3 startPos;

    private void Start()
    {
        startPos = rightHandTarget.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Grab"))
        {
            rightHandTarget.position = Vector3.Lerp(rightHandTarget.position, other.transform.position, Time.deltaTime * lerpSpeed);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Grab"))
        {
            rightHandTarget.position = Vector3.Lerp(rightHandTarget.position, other.transform.position, Time.deltaTime * lerpSpeed);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Grab"))
        {
            rightHandTarget.position = Vector3.Lerp(rightHandTarget.position, startPos, Time.deltaTime * lerpSpeed);
        }
    }
}