using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class typescript : MonoBehaviour
{
	private Text text;


	void Awake()
	{
		text = GetComponent<Text>();
	}
	// Use this for initialization
	void Start()
	{
		StartCoroutine(BeginText());

	}

	// Update is called once per frame
	void Update()
	{

	}
	IEnumerator BeginText()
    {
		text.DOText("ԭ��������������ס�����ˣ�ԭ�����ǵİ�������������ô������Ϊ�ҶԿ�����ľ�������Ϊ���ܵ��꣬һĻĻ�����㣬һ����Ⱦ������", 10f).SetLoops(0);
		yield return 0;
	}
}