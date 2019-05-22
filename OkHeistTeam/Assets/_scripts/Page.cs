using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page : MonoBehaviour
{
    public Dossier myfile;
    public Vector3 targetPos;
    public float speed;
    public string myData;
    public bool isNotPage;
    public int pageNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

        if (isNotPage == false && Vector3.Distance(transform.localPosition, targetPos) > 0)
        { transform.localPosition = Vector3.MoveTowards(transform.localPosition,targetPos,  speed * Time.deltaTime); }
    }
    public void OnMouseDown()
    {
        Debug.Log("clicked");
        if (isNotPage == false) { myfile.ChangePage(GetComponent<Page>()); }
        else { myfile.Clicked(); }
       
    }
    public void SetTargetPos(Vector3 newPos)
    { targetPos = newPos; }
}
