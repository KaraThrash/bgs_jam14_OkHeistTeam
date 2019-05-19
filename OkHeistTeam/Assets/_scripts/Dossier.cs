using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dossier : MonoBehaviour
{
    public CriminalManager criminalManager;
    public GameObject frontPicture, skillsPage, likesPage, dislikesPage,openSpot,closedSpot,clickTargetObj;
    public Page openPage;
    public List<Page> pages;
    public Text displayText,skillsText, likesText, dislikesText;
    public List<AudioClip> pageTurnSounds;
    public bool focused;
    public culprit myCriminal;
    // Start is called before the first frame update

    public void SetCriminal(culprit newCriminal)
    {
        pages[0].myData = newCriminal.skilltext;
        pages[1].myData = newCriminal.liketext;
        pages[2].myData = newCriminal.disliketext;
        
        myCriminal = newCriminal;

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

        if (focused == true)
        {
            if (Vector3.Distance(openPage.gameObject.transform.localPosition, openSpot.transform.localPosition) > 0)
            {
                // displayText.text = "";
                openPage.transform.localPosition = Vector3.MoveTowards(openPage.transform.localPosition, openSpot.transform.localPosition, 1 * Time.deltaTime);
            }
            else { SetDisplayText(openPage); }
        }
        if (transform.position.y < 1) { transform.position = criminalManager.resetSpot.position; }

    }
    public void ChangePage(Page newOpenPage)
    {
        if (focused == true)
        {
            displayText.text = "";
            GetComponent<AudioSource>().clip = pageTurnSounds[Random.Range(0, pageTurnSounds.Count)];
            GetComponent<AudioSource>().Play();
            //    Play(pageTurnSounds[Random.Range(0,pageTurnSounds.Count)]);
            openPage.SetTargetPos(closedSpot.transform.localPosition);
            openPage = newOpenPage;
            newOpenPage.SetTargetPos(openSpot.transform.localPosition);
        }
    }
    public void SetDisplayText(Page openedPage)
    {
        
        string newtext = "";
        switch (openedPage.pageNumber)
        {
            case 0:
                displayText.text = "Skills: \n" + openPage.myData;
                break;
            case 1:
                displayText.text = "Likes: \n" + openPage.myData;
                break;
            case 2:
                displayText.text = "Dislikes: \n" + openPage.myData;
                break;
            default:
                newtext = "whoops";
                break;

        }
       // displayText.text = newtext;
    }

    public void Clicked()
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
        {
            openPage.targetPos = closedSpot.transform.localPosition;
            openPage.transform.localPosition = closedSpot.transform.localPosition;
            displayText.text = "";
            focused = false; GetComponent<Rigidbody>().isKinematic = false; GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Rigidbody>().AddForce( (criminalManager.desktopSpot.position - transform.position).normalized * 412.0F * Time.deltaTime,ForceMode.Impulse); }
        else
        { focused = true; GetComponent<Rigidbody>().useGravity = false; } }

    public void Picked()
    {
        if (focused == true)
        {
            openPage.transform.localPosition = closedSpot.transform.localPosition;
            displayText.text = "";
            focused = false; GetComponent<Rigidbody>().isKinematic = false; GetComponent<Rigidbody>().useGravity = true;
            clickTargetObj.active = false;
        }
        else
        { focused = true; GetComponent<Rigidbody>().useGravity = false; }
    }
}


