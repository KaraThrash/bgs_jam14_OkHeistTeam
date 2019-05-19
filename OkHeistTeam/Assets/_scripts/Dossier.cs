using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dossier : MonoBehaviour
{
    public CriminalManager criminalManager;
    public int placeInMasterList;
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
        pages[0].myData = newCriminal.description;
        pages[1].myData = newCriminal.skilltext;
        pages[2].myData = newCriminal.liketext;
        pages[3].myData = newCriminal.disliketext;
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
        
        string newtext = ""; displayText.fontSize = 20;
        switch (openedPage.pageNumber)
        {
            case 0:
                displayText.fontSize = 15;
                displayText.text = myCriminal.name + "\n" + "\n" + "Description: \n" + "\n" +  openPage.myData;
                break;
            case 1:
                displayText.text = myCriminal.name + "\n" + "\n" + "Skills: \n" + "\n" + openPage.myData;
                break;
            case 2:
                displayText.text = myCriminal.name + "\n" + "\n" + "Likes: \n" + "\n" + openPage.myData;
                break;
            case 3:
                displayText.text = myCriminal.name + "\n" + "\n" + "Dislikes: \n" + "\n" + openPage.myData;
                break;
            default:
                newtext = "whoops";
                break;

        }
       // displayText.text = newtext;
    }

    public void Clicked()
    {
        if (criminalManager.onTeam.Count > 3) { GetComponent<Rigidbody>().AddForce(Vector3.up * 150.0f * Time.deltaTime,ForceMode.Impulse); }
        else
        {
            if (focused == true)
            {
                if (openPage != null) { openPage.transform.localPosition = closedSpot.transform.localPosition; }
                criminalManager.ChangeFocusedDossier(GetComponent<Dossier>());
                // focused = false; GetComponent<Rigidbody>().useGravity = true;
                // GetComponent<Rigidbody>().isKinematic = false;
                // GetComponent<Rigidbody>().AddForce(criminalManager.desktopSpot.position - transform.position * 5.0F * Time.deltaTime, ForceMode.Impulse);
            }
            else { criminalManager.ChangeFocusedDossier(GetComponent<Dossier>()); if (openPage != null) { openPage.transform.localPosition = closedSpot.transform.localPosition; } }
        }
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


