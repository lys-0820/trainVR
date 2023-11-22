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
		text.DOText("原来你是我最想留住的幸运，原来我们的爱情曾经靠得那么近，那为我对抗世界的决定，那为我淋的雨，一幕幕都是你，一尘不染的真心", 10f).SetLoops(0);
		yield return 0;
	}
}