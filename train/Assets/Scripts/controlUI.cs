
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;//����������
using UnityEngine.UI;
//����״̬�����桢����
public enum CardState
{
    Front,
    Back
}
public class controlUI : MonoBehaviour
{
    public GameObject mFront;//��������
    public GameObject mBack;//���Ʊ���
    public CardState mCardState = CardState.Front;//���Ƶ�ǰ��״̬�������滹�Ǳ��棿
    public float mTime = 0.3f;
    private bool isActive = false;//true��������ִ�з�ת���������
    private Color frontColor;
    private Color backColor;
    /// <summary>
    /// ��ʼ�����ƽǶȣ�����mCardState
    /// </summary>
    public void Init()
    {
        if (mCardState == CardState.Front)
        {
            //�����濪ʼ
            setBackInvisible();
        }
        else
        {
            //�ӱ��濪ʼ
            setFrontInvisible();
        }
    }
    private void Start()
    {
        
        Init();
    }

    /// <summary>
    /// ���������õĽӿ�
    /// </summary>
    public void StartBack()
    {

        setFrontInvisible();
    }
    /// <summary>
    /// ���������õĽӿ�
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
