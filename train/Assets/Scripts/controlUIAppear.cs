using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;
using DG.Tweening;
public class controlUIAppear : MonoBehaviour
{
    [SerializeField] GameObject selectCards;
    [SerializeField] GameObject personDescription;
    [SerializeField] GameObject bg;
    [SerializeField] Animator animator;
    [SerializeField] Text text;
    [SerializeField] Button startBt;
    // Start is called before the first frame update
    void Start()
    {

        bg.SetActive(true);
        selectCards.SetActive(true);
        personDescription.SetActive(false);
        startBt.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickConfirm()
    {
        selectCards.SetActive(false);
        personDescription.SetActive(true);
        Tweener tweener = text.DOText("ԭ��������������ס�����ˣ�ԭ�����ǵİ�������������ô������Ϊ�ҶԿ�����ľ�������Ϊ���ܵ��꣬һĻĻ�����㣬һ����Ⱦ������", 10f).SetLoops(0);
        tweener.OnComplete(setBtVisible);
        
        
    }
    public void onClickBegin()
    {
        personDescription.SetActive(false);
        bg.SetActive(false);

        animator.SetTrigger("enter");
    }
    void setBtVisible()
    {
        startBt.gameObject.SetActive(true);
    }
    IEnumerator BeginText()
    {
        
       
        yield return 0;
    }
}
