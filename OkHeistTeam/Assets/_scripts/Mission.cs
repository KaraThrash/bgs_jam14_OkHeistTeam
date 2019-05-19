using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public struct Challenge
{
    public string name;
    public string description;
    public string successStory;
    public string failStory;
    public int difficulty;
    public List<string> skills;
    public List<string> likes;
    public int money;
    public int prestige;
    public bool failmission; //does the mission end(T) or continue(F)?
    public bool criminalAssigned ;
    public int assignedCriminal; //refers to masater list
}


public class Mission : MonoBehaviour
{
    // Start is called before the first frame update

    public MissionManager missionManager;
    public List<Challenge> challenges;
    public string name;
    int money;
    int prestige;
    int currentMoney;
    int currentPrestige;

    void Start()
    {
        
       // MakeChallenges();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void MakeChallenges()
    {
        challenges = new List<Challenge>();
        CreateChallenge();
        CreateChallenge();
        CreateChallenge();
        CreateChallenge();

    }

    public void CreateChallenge()
    {
        Challenge tempChallenge;//= new Challenge();

        tempChallenge.name = "challengeName";
        tempChallenge.description = "challengeDescription";

        tempChallenge.successStory = "successstory"; 
        tempChallenge.failStory = "fail";
        tempChallenge.difficulty = 1;
        tempChallenge.skills = new List<string>();
        tempChallenge.likes = new List<string>();
        tempChallenge.money = 1;
        tempChallenge.prestige = 1;
        tempChallenge.failmission = true; //does the mission end(T) or continue(F)?
        tempChallenge.criminalAssigned = false;
        tempChallenge.assignedCriminal = -1; //refers to masater list

        challenges.Add(tempChallenge);

    }
    public void ChallengeLoop()
    {
        if (challenges.Count > 0)
        {
           // ChallengeCheck();

        }
    }

    public bool ChallengeCheck(ChallengeUi uiElement)
    {
        //pop last challenge from the list and check skills against the assigned criminal
        uiElement.gameObject.active = true;
        Debug.Log(challenges.Count);
        Challenge currentChallenge = challenges[challenges.Count - 1];
        challenges.RemoveAt(challenges.Count - 1);



        //if no criminalk assigned return immediatly
        //if (currentChallenge.criminalAssigned == false) {
        //    uiElement.assigned.text = "Nobody";
        //    uiElement.description.text = currentChallenge.name;
        //    uiElement.name.text = "Fail";
        //    uiElement.reward.text = "NOTHING!";
        //    return currentChallenge.failmission; }

        culprit tempCulprit = missionManager.criminalManager.criminalMasterList[currentChallenge.assignedCriminal];
        int likeModifier = 0;

       
           
                foreach (string elLike in currentChallenge.likes)
                {
                    //check criminal likes for bonus
                    if (tempCulprit.likes.Contains(elLike) == true)
                    {
                    likeModifier += 2;
                    }
                    //check criminal dislikes for negative
                    if (tempCulprit.dislikes.Contains(elLike) == true)
                    {
                    likeModifier -= 2;
                    }

                }

                foreach (string el in currentChallenge.skills)
                {
                    int criminalskillcheckvalue = 0;
                    //check if has skill
                    if (tempCulprit.skillList.ContainsKey(el) == true)
                    {
                        criminalskillcheckvalue += tempCulprit.skillList[el]; 
                    }
                    criminalskillcheckvalue += likeModifier;
                    //check against difficulty
                    if (criminalskillcheckvalue >= currentChallenge.difficulty)
                    {
                        UpdateMoney(money,prestige);

                uiElement.assigned.text = tempCulprit.name;
                uiElement.description.text = currentChallenge.name;
                uiElement.name.text = "Passed";
                uiElement.reward.text = currentChallenge.money.ToString();

                Debug.Log("PASS");
                        return false;
                    }
                }
        uiElement.assigned.text = tempCulprit.name;
        uiElement.description.text = currentChallenge.name;
        uiElement.name.text = "Fail";
        uiElement.reward.text = "NOTHING!";
        Debug.Log("Fail");
        return currentChallenge.failmission; //if the challenge is not a lose state continue mission without rewards
    }

    public void UpdateMoney(int moneyChange,int prestigeChange)
    {
        currentMoney += moneyChange;
        currentPrestige += prestigeChange;
    }

}
