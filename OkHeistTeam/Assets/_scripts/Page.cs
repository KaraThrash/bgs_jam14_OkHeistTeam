using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page : MonoBehaviour
{
    public Dossier myfile;
    public Vector3 targetPos;
    public float speed;
    public string myData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

        if (Vector3.Distance(transform.localPosition, targetPos) > 0)
        { transform.localPosition = Vector3.MoveTowards(transform.localPosition,targetPos,  speed * Time.deltaTime); }
    }
    public void OnMouseDown()
    {
        myfile.ChangePage(GetComponent<Page>());
    }
    public void SetTargetPos(Vector3 newPos)
    { targetPos = newPos; }
}
