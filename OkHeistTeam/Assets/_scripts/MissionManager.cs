using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionManager : MonoBehaviour
{
    public CriminalManager criminalManager;
    public List<string> debugSkills;
    public List<string> debugLikes;
    public List<Vector2> challengeAndCriminal; //which challenge has which criminal assigned
    public Mission currentMission;
    public List<ChallengeUi> challengeUI,challengeCrawl;
    public List<Text> teamButtonText;
    public int selectedChallenge,activeCrawl;
    public GameObject crawlObject,challengeAssignObject,challengehighlight,memberhighlight,resultScreen;


    // Start is called before the first frame update
    void Start()
    {
        StartSelectionPhase();
    }

    // Update is called once per frame
    void Update()
    {
       // if (Input.GetKeyDown(KeyCode.Space))
      //  { CreateCriminal(); }
    }
    public void StartAssignPhase()
    {
        if (criminalManager.onTeam.Count > 3)
        {
            challengeAssignObject.active = true;
            int count = 0;
            while (count < teamButtonText.Count && count < criminalManager.onTeam.Count)
            {
                teamButtonText[count].text = criminalManager.criminalMasterList[criminalManager.onTeam[count]].name;
                count++;
            }
            count = 0;
            while (count < challengeUI.Count && count < currentMission.challenges.Count)
            {

                challengeUI[count].gameObject.active = true;
                challengeUI[count].name.text = currentMission.challenges[count].name;
                count++;
            }
        }
    }
    public void StartSelectionPhase()
    {
        resultScreen.active = false;
        crawlObject.active = false;
        challengeAssignObject.active = false;
        activeCrawl = -1;
        selectedChallenge = -1;
        CreateMission();
        criminalManager.RestartPhase();
    }
    public void NextMission()
    {

        crawlObject.active = false;
        challengeAssignObject.active = false;

    }
    public void EmbarkOnMission()
    {
        activeCrawl = -1;
        crawlObject.active = true;
        challengeAssignObject.active = false;
     
        

    }
    public void NextChallenge()
    {
       
        activeCrawl++;
        if (activeCrawl >= challengeCrawl.Count || activeCrawl >= currentMission.challenges.Count) { ShowResults(); }
        else
        {
            currentMission.ChallengeCheck(challengeCrawl[activeCrawl]);
        }

    }
    public void ShowResults()
    {
        crawlObject.active = false;
        challengeAssignObject.active = false;
        resultScreen.active = true;

    }
    public void challengeClicked(int numberinlist)
    {
        if (numberinlist < currentMission.challenges.Count && numberinlist > -1)
        {
            challengehighlight.transform.position = challengeUI[numberinlist].transform.position;
            if (criminalManager.currentSelectedTeamMember > -1)
            {
                //if criminal highlighted assign them to the clicked challenge
                challengeUI[numberinlist].assigned.text = criminalManager.criminalMasterList[criminalManager.onTeam[criminalManager.currentSelectedTeamMember]].name;
                Challenge tempchallenge = currentMission.challenges[numberinlist];
                tempchallenge.assignedCriminal = criminalManager.onTeam[criminalManager.currentSelectedTeamMember];
                tempchallenge.criminalAssigned = true;
                currentMission.challenges[numberinlist] = tempchallenge;
                criminalManager.currentSelectedTeamMember = -1;
                selectedChallenge = -1;
            }
            else { selectedChallenge = numberinlist; }
        }
    }
    public void criminalClicked(int numberinlist)
    {
        if (numberinlist < criminalManager.onTeam.Count && numberinlist > -1)
        {
            memberhighlight.transform.position = teamButtonText[numberinlist].transform.position;
            if (selectedChallenge > -1)
            {
                //if criminal highlighted assign them to the clicked challenge
                challengeUI[selectedChallenge].assigned.text = criminalManager.criminalMasterList[criminalManager.onTeam[numberinlist]].name;
                Challenge tempchallenge = currentMission.challenges[selectedChallenge];
                tempchallenge.assignedCriminal = criminalManager.onTeam[numberinlist];
                currentMission.challenges[selectedChallenge] = tempchallenge;
                tempchallenge.criminalAssigned = true;
                criminalManager.currentSelectedTeamMember = -1;
                selectedChallenge = -1;
            }
            else { criminalManager.currentSelectedTeamMember = numberinlist; }
        }
    }


    public void CreateMission()
    {
        currentMission = Instantiate(currentMission, Vector3.zero, transform.rotation) as Mission;
       currentMission.MakeChallenges();
        int count = 0;
        foreach (ChallengeUi el in challengeUI)
        {
            if (currentMission.challenges != null)
            {
                el.name.text = currentMission.challenges[count].name; 
                el.description.text = currentMission.challenges[count].description; count++;
            }
        }
        //CreateChallenge();
        //CreateChallenge();
        //CreateChallenge();


    }
    public void CreateChallenge()
    {
        //Challenge tempChallenge = new Challenge();

        //tempChallenge.name = "challengeName";
        //tempChallenge.description = "challengeDescription";
        //currentMission.challenges.Add(tempChallenge);

    }


    public void CreateCriminal()
    {

       
    }
}
