using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class train : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(trainEnter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator trainEnter()
    {
        yield return new WaitForSeconds(5.0f);
        animator.SetTrigger("enter");
    }
}
