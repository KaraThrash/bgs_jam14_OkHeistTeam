using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dossier : MonoBehaviour
{
    public GameObject frontPicture, skillsPage, likesPage, dislikesPage,openSpot,closedSpot;
    public GameObject openPage;
    public Text skillsText, likesText, dislikesText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangePage(GameObject newOpenPage)
    {
        openPage.GetComponent<Page>().SetTargetPos(closedSpot.transform.localPosition);
        newOpenPage.GetComponent<Page>().SetTargetPos(openSpot.transform.localPosition);
    }
}
