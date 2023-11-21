
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;//别忘了引用
using UnityEngine.UI;
//卡牌状态，正面、背面
public enum CardState
{
    Front,
    Back
}
public class controlUI : MonoBehaviour
{
    public GameObject mFront;//卡牌正面
    public GameObject mBack;//卡牌背面
    public CardState mCardState = CardState.Front;//卡牌当前的状态，是正面还是背面？
    public float mTime = 0.3f;
    private bool isActive = false;//true代表正在执行翻转，不许被打断
    private Color frontColor;
    private Color backColor;
    /// <summary>
    /// 初始化卡牌角度，根据mCardState
    /// </summary>
    public void Init()
    {
        if (mCardState == CardState.Front)
        {
            //从正面开始
            setBackInvisible();
        }
        else
        {
            //从背面开始
            setFrontInvisible();
        }
    }
    private void Start()
    {
        
        Init();
    }

    /// <summary>
    /// 留给外界调用的接口
    /// </summary>
    public void StartBack()
    {

        setFrontInvisible();
    }
    /// <summary>
    /// 留给外界调用的接口
    /// </summary>
    public void StartFront()
    {
        setBackInvisible();
    }

    private void setFrontInvisible()
    {
        mFront.gameObject.SetActive(false);
        mBack.gameObject.SetActive(true);

    }
    private void setBackInvisible()
    {
        mFront.gameObject.SetActive(true);
        mBack.gameObject.SetActive(false);

    }
}
