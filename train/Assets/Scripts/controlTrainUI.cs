using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
public class controlTrainUI : MonoBehaviour
{
    [SerializeField] GameObject textObj;
    [SerializeField] Text NPCText;
    [SerializeField] List<string> NPCTextList;
    [SerializeField] Button nextBt;
    [SerializeField] GameObject questionObj;
    [SerializeField] GameObject downNotice;
    public int currentIndex;
    public XRRayInteractor rayInteractor;
    RaycastHit hit;
    InputDevice rightHand;
    // Start is called before the first frame update
    void Start()
    {
        questionObj.SetActive(true);
        //OnEnable();
        textObj.SetActive(false);
        //nextBt.gameObject.SetActive(false);
        rightHand = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
        downNotice.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        bool rightTriggerValue;
        if (rayInteractor.TryGetCurrent3DRaycastHit(out hit))
        {

            string name = hit.collider.name;
            
            if (hit.collider.gameObject.tag.CompareTo("dialogue") == 0)
            {
                Debug.Log(name);
                if (rightHand.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton,
     out rightTriggerValue)&&rightTriggerValue)
                {
                    textObj.SetActive(true);
                    questionObj.SetActive(false);
                    OnEnable();
                }
            }

        }
    }
    public void CloseDialog() //���Closeִ�У��رնԻ�Panel
    {
        textObj.SetActive(false);
    }

    public void ContinueDialog()    //���Continue��ťִ�У������¾仰
    {
        nextBt.gameObject.SetActive(false);
        currentIndex++;
        if (currentIndex < NPCTextList.Count)
        {
            NPCText.text = "";
            Tweener tweener =  NPCText.DOText(NPCTextList[currentIndex], 5f).SetEase(Ease.Linear);
            tweener.OnComplete(setBtVisible);
        }
        else
        {
            CloseDialog();
            downNotice.SetActive(false);
        }
    }
    private void setBtVisible()
    {
        nextBt.gameObject.SetActive(true);
    }
    private void OnEnable() //�ڼ���Ի���尴ťʱ������Ŀ����Ϊ��ʹ������0
    {
        nextBt.gameObject.SetActive(false);
        currentIndex = 0;
        NPCText.text = "";
        Tweener tweener = NPCText.DOText(NPCTextList[currentIndex], 5f).SetEase(Ease.Linear);
        tweener.OnComplete(setBtVisible);
    }
    
    public void getRayPoint()
    {
        bool rightTriggerValue;
        //��⵽������ײ
        if (rayInteractor.TryGetCurrent3DRaycastHit(out hit))
        {

            string name = hit.collider.name;
            
            if (hit.collider.gameObject.tag.CompareTo("dialogue") == 0)
            {
                //���°����
                if (rightHand.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton,
     out rightTriggerValue))
                {
                    Debug.Log(name);
                    textObj.SetActive(true);
                    questionObj.SetActive(false);
                    OnEnable();
                }
            }

        }

    }

}
