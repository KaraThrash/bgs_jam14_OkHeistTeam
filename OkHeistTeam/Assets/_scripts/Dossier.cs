using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dossier : MonoBehaviour
{
    public CriminalManager criminalManager;
    public GameObject frontPicture, skillsPage, likesPage, dislikesPage,openSpot,closedSpot;
    public Page openPage;
    public List<Page> pages;
    public Text displayText,skillsText, likesText, dislikesText;
    public List<AudioClip> pageTurnSounds;
    public bool focused;
    public culprit myCriminal;
    // Start is called before the first frame update

    public void SetCriminal(culprit newCriminal)
    {
        //skillsText = newCriminal.skilltext;
        //likesText = newCriminal.liketext;
        //dislikesText = newCriminal.disliketext;
        //myCriminal = newCriminal;

    }
    void Start()
    {
        foreach (Page el in pages)
        { el.SetTargetPos(closedSpot.transform.localPosition); }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        { ChangePage(pages[Random.Range(0,pages.Count)]); }
       

            if (Vector3.Distance(openPage.gameObject.transform.localPosition, openSpot.transform.localPosition) > 0)
        {
            displayText.text = "";
            openPage.transform.localPosition = Vector3.MoveTowards(openPage.transform.localPosition, openSpot.transform.localPosition, 1 * Time.deltaTime); }
        else { displayText.text = openPage.myData; }
        if (transform.position.y < 1) { transform.position = criminalManager.resetSpot.position; }

    }
    public void ChangePage(Page newOpenPage)
    {
        GetComponent<AudioSource>().clip = pageTurnSounds[Random.Range(0, pageTurnSounds.Count)];
        GetComponent<AudioSource>().Play();
        //    Play(pageTurnSounds[Random.Range(0,pageTurnSounds.Count)]);
        openPage.SetTargetPos(closedSpot.transform.localPosition);
        openPage = newOpenPage;
        newOpenPage.SetTargetPos(openSpot.transform.localPosition);
    }
    public void OnMouseDown()
    {
        if (focused == true)
        {
            criminalManager.ChangeFocusedDossier(GetComponent<Dossier>());
           // focused = false; GetComponent<Rigidbody>().useGravity = true;
           // GetComponent<Rigidbody>().isKinematic = false;
           // GetComponent<Rigidbody>().AddForce(criminalManager.desktopSpot.position - transform.position * 5.0F * Time.deltaTime, ForceMode.Impulse);
        }
        else { criminalManager.ChangeFocusedDossier(GetComponent<Dossier>()); }
        
    }
    public void ChangeFocus()
    {
        if (focused == true)
        { focused = false; GetComponent<Rigidbody>().isKinematic = false; GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Rigidbody>().AddForce( (criminalManager.desktopSpot.position - transform.position).normalized * 412.0F * Time.deltaTime,ForceMode.Impulse); }
        else
        { focused = true; GetComponent<Rigidbody>().useGravity = false; } }

}
