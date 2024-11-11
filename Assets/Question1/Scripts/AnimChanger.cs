using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimChanger : MonoBehaviour
{
    private Animator animator;
    private int numOfEntries;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        numOfEntries++;
        if (numOfEntries > 4) numOfEntries = 1;

        switch (numOfEntries)
        {
            case 1:
                animator.SetLayerWeight(animator.GetLayerIndex("NormalLayer"), 1f);
                animator.SetLayerWeight(animator.GetLayerIndex("AxeLayer"), 0f);
                animator.SetLayerWeight(animator.GetLayerIndex("SwordLayer"), 0f);
                animator.SetLayerWeight(animator.GetLayerIndex("BowLayer"), 0f);
                break;
            case 2:
                animator.SetLayerWeight(animator.GetLayerIndex("NormalLayer"), 0f);
                animator.SetLayerWeight(animator.GetLayerIndex("AxeLayer"), 1f);
                animator.SetLayerWeight(animator.GetLayerIndex("SwordLayer"), 0f);
                animator.SetLayerWeight(animator.GetLayerIndex("BowLayer"), 0f);
                break;
            case 3:
                animator.SetLayerWeight(animator.GetLayerIndex("NormalLayer"), 0f);
                animator.SetLayerWeight(animator.GetLayerIndex("AxeLayer"), 0f);
                animator.SetLayerWeight(animator.GetLayerIndex("SwordLayer"), 1f);
                animator.SetLayerWeight(animator.GetLayerIndex("BowLayer"), 0f);
                break;
            case 4:
                animator.SetLayerWeight(animator.GetLayerIndex("NormalLayer"), 0f);
                animator.SetLayerWeight(animator.GetLayerIndex("AxeLayer"), 0f);
                animator.SetLayerWeight(animator.GetLayerIndex("SwordLayer"), 0f);
                animator.SetLayerWeight(animator.GetLayerIndex("BowLayer"), 1f);
                break;
        }
    }
}