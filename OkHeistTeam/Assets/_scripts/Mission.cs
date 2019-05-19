using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Google2u;
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
        

    }

    public void CreateChallenge()
    {
        foreach (MissionsRow el in Missions.Instance.Rows)
        {
            //culprit newCriminal = CreateCriminal(el);
            //newCriminal.placeInMasterList = criminalMasterList.Count - 1;
            //criminalMasterList.Add(newCriminal);

            //GameObject clone = Instantiate(dossierPrefab, spawnPos, resetSpot.rotation) as GameObject;

            //pictureList.transform.GetChild(0).position = clone.GetComponent<Dossier>().frontPicture.transform.position;
            //pictureList.transform.GetChild(0).rotation = clone.GetComponent<Dossier>().frontPicture.transform.rotation;
            //pictureList.transform.GetChild(0).parent = clone.transform;

            //dossierList.Add(clone);
            //clone.GetComponent<Dossier>().SetCriminal(newCriminal);
            //clone.GetComponent<Renderer>().material = folderColors[Random.Range(0, folderColors.Count)];
            //spawnPos = new Vector3(spawnPos.x + 0.1f, spawnPos.y + 0.1f, spawnPos.z);


            if (Random.Range(0, 4) < 3)
            {

                Challenge tempChallenge;//= new Challenge();

                Debug.Log("New Challenge " + el._PassingSkill1 + " " + el._PassingSkill2 + " " + el._PassingSkill3 + " " + el._Challenges);
                tempChallenge.name = " " + el._PassingSkill1 + " " + el._PassingSkill2 + " " + el._PassingSkill3 + " ";
                tempChallenge.description = el._Challenges;

                tempChallenge.successStory = el._PassText;
                tempChallenge.failStory = el._fAILtEXT;
                tempChallenge.difficulty = 1;
                tempChallenge.skills = new List<string>();
                tempChallenge.skills.Add(el._PassingSkill1);
                tempChallenge.skills.Add(el._PassingSkill2);
                tempChallenge.skills.Add(el._PassingSkill3);

                tempChallenge.likes = new List<string>();
                tempChallenge.likes.Add(el._LikeBonus);

                tempChallenge.money = 1;
                tempChallenge.prestige = 1;
                tempChallenge.failmission = true; //does the mission end(T) or continue(F)?
                tempChallenge.criminalAssigned = false;
                tempChallenge.assignedCriminal = -1; //refers to masater list

                challenges.Add(tempChallenge);
            }
            else { Debug.Log("Missed roll"); }
            if (challenges.Count > 3) { return; }
        }




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

        if (currentChallenge.assignedCriminal == -1)
        {
            uiElement.challengeResult.text = "No one was sent to " + currentChallenge.description;
            return false;
        }
      
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
                    UpdateMoney(money, prestige);

                    uiElement.assigned.text = tempCulprit.name;
                    uiElement.description.text = currentChallenge.name;
                    uiElement.name.text = "Passed";
                    uiElement.reward.text = currentChallenge.money.ToString();

                    Debug.Log("PASS");
                    string tempstring2 = currentChallenge.successStory.Replace("%PersonName%", tempCulprit.name);
                    tempstring2 = tempstring2.Replace("%SkillName%", el);
                    uiElement.challengeResult.text = tempstring2;
                    return false;
                }
            }
        
        uiElement.assigned.text = tempCulprit.name;
        uiElement.description.text = currentChallenge.name;
        uiElement.name.text = "Fail";
        uiElement.reward.text = "NOTHING!";

        string tempstring = currentChallenge.failStory.Replace("%PersonName%", tempCulprit.name);



        uiElement.challengeResult.text = tempstring;

        Debug.Log("Fail");
        return currentChallenge.failmission; //if the challenge is not a lose state continue mission without rewards
    }

    public void UpdateMoney(int moneyChange,int prestigeChange)
    {
        currentMoney += moneyChange;
        currentPrestige += prestigeChange;
    }

}
