using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Pico;
using UnityEngine.XR;

public class remyAction : MonoBehaviour
{
    InputDevice leftHand;
    InputDevice rightHand;
    public Animator animator;
    public Animator trainAnim;
    // Start is called before the first frame update
    void Start()
    {

        leftHand = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        rightHand = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
    }

    // Update is called once per frame
    void Update()
    {
        //获取扳机键是否被按下
        bool triggerValue;
        bool rightTriggerValue;
        if (leftHand.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton,
            out triggerValue) && triggerValue)
        {
            Debug.Log("Trigger button is pressed.");
            animator.SetBool("walk",true);
        }
        else
        {
            animator.SetBool("walk", false);
        }
        if (rightHand.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton,
            out rightTriggerValue) && rightTriggerValue)
        {
            trainAnim.SetTrigger("close the door");
            StartCoroutine(leave());
        }
        
    }
    IEnumerator leave()
    {
        yield return new WaitForSeconds(5.0f);
        animator.SetTrigger("leave");
    }
}
