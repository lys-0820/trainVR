using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class rollCard : MonoBehaviour
{
    [SerializeField] GameObject image1;
    [SerializeField] GameObject image2;
    [SerializeField] GameObject image3;
    private LinkedList<GameObject> imageList;
    private LinkedListNode<GameObject> currentNode;
    // Start is called before the first frame update
    void Start()
    {
        imageList = new LinkedList<GameObject>();
        imageList.AddLast(image1);
        imageList.AddLast(image2);
        imageList.AddLast(image3);
        if (imageList.Count > 0)
        {
            currentNode = imageList.First.Next;
        }
        InitCards(currentNode);
    }

    public void onClickPrevious()
    {
        if (currentNode!=null)
        {
            SetPreAnim(currentNode);
            currentNode = currentNode.Next ?? imageList.First;

        }
    }
    public void onClickNext()
    {
        if (currentNode != null)
        {
            SetNextAnim(currentNode);
            currentNode = currentNode.Previous ?? imageList.Last;
            
            
        }
    }
    private void InitCards(LinkedListNode<GameObject> node)
    {
        node.Value.transform.DOScale(new Vector3(1f, 1f, 1f), 1);
        (node.Previous ?? imageList.Last).Value.transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 1);
        (node.Next ?? imageList.First).Value.transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 1);
    }
    private void SetPreAnim(LinkedListNode<GameObject> node)
    {
        node.Value.transform.DOLocalMoveY(130, 1);
        node.Value.transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 1);
        (node.Previous ?? imageList.Last).Value.transform.DOLocalMoveY(-130, 1);
        (node.Previous ?? imageList.Last).Value.transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 1);
        (node.Next ?? imageList.First).Value.transform.DOLocalMoveY(0, 1);
        (node.Next ?? imageList.First).Value.transform.DOScale(new Vector3(1f, 1f, 1f), 1);
    }
    private void SetNextAnim(LinkedListNode<GameObject> node)
    {
        node.Value.transform.DOLocalMoveY(-130, 1);
        node.Value.transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 1);
        (node.Previous ?? imageList.Last).Value.transform.DOLocalMoveY(0, 1);
        (node.Previous ?? imageList.Last).Value.transform.DOScale(new Vector3(1f, 1f, 1f), 1);
        (node.Next ?? imageList.First).Value.transform.DOLocalMoveY(130, 1);
        (node.Next ?? imageList.First).Value.transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 1);
    }
}
