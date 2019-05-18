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
    public culprit assignedCriminal;
}


public class Mission : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Challenge> challenges;
    int money;
    int prestige;
    int currentMoney;
    int currentPrestige;

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void ChallengeLoop()
    {
        if (challenges.Count > 0)
        {
            ChallengeCheck();

        }
    }

    public bool ChallengeCheck()
    {
        //pop last challenge from the list and check skills against the assigned criminal
       

        Challenge currentChallenge = challenges[challenges.Count - 1];
        challenges.RemoveAt(challenges.Count - 1);

        //if no criminalk assigned return immediatly
        if (currentChallenge.criminalAssigned == false) { return currentChallenge.failmission; }


                int likeModifier = 0;

       
           
                foreach (string elLike in currentChallenge.likes)
                {
                    //check criminal likes for bonus
                    if (currentChallenge.assignedCriminal.likes.Contains(elLike) == true)
                    {
                    likeModifier += 2;
                    }
                    //check criminal dislikes for negative
                    if (currentChallenge.assignedCriminal.dislikes.Contains(elLike) == true)
                    {
                    likeModifier -= 2;
                    }

                }

                foreach (string el in currentChallenge.skills)
                {
                    int criminalskillcheckvalue = 0;
                    //check if has skill
                    if (currentChallenge.assignedCriminal.skillList.ContainsKey(el) == true)
                    {
                        criminalskillcheckvalue += currentChallenge.assignedCriminal.skillList[el]; 
                    }
                    criminalskillcheckvalue += likeModifier;
                    //check against difficulty
                    if (criminalskillcheckvalue >= currentChallenge.difficulty)
                    {
                        UpdateMoney(money,prestige);
                Debug.Log("PASS");
                        return false;
                    }
                }
        Debug.Log("Fail");
        return currentChallenge.failmission; //if the challenge is not a lose state continue mission without rewards
    }

    public void UpdateMoney(int moneyChange,int prestigeChange)
    {
        currentMoney += moneyChange;
        currentPrestige += prestigeChange;
    }

}
