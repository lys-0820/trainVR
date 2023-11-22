using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionTest : MonoBehaviour
{
    public Camera cam;
    public int distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider e)
    {
        if (e.gameObject.tag.CompareTo("NPC") == 0)
        {
            Debug.Log(e.gameObject.name);
            StartCoroutine(PlayPop(e.gameObject));
        }


    }
    IEnumerator PlayPop(GameObject obj)
    {
        Transform pop =  obj.transform.Find("pop");
        pop.gameObject.SetActive(true);
        var forward = cam.transform.TransformDirection(Vector3.forward);

        pop.transform.position = cam.transform.position + forward * distance;
        pop.transform.forward = new Vector3(transform.position.x, 0, transform.position.z) - new Vector3(cam.transform.position.x, 0, cam.transform.position.z);
        yield return new WaitForSeconds(4f);
        pop.gameObject.SetActive(false);
    }


}
