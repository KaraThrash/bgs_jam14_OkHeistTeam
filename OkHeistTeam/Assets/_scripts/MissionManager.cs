using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionManager : MonoBehaviour
{
    public List<string> debugSkills;
    public List<string> debugLikes;
    public List<culprit> criminals;
    public Mission currentMission;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { CreateCriminals(); }
    }

    public void CreateMission()
    {
        currentMission = new Mission();


        
    }

    public void CreateCriminals()
    {
        culprit newCriminal;
        newCriminal.likes = new List<string>();
        newCriminal.dislikes = new List<string>();
        newCriminal.skillList = new Dictionary<string, int>();

        int rnd = Random.Range(0, debugSkills.Count);
        newCriminal.skillList.Add(debugSkills[rnd], Random.Range(-10,11));
        Debug.Log("Adding Skill: " + debugSkills[rnd] + " at value "  );
         rnd = Random.Range(0, debugSkills.Count);

        if (newCriminal.skillList.ContainsKey(debugSkills[rnd])) { newCriminal.skillList[debugSkills[rnd]] = newCriminal.skillList[debugSkills[rnd]] + 2; }
        else { newCriminal.skillList.Add(debugSkills[rnd], Random.Range(-10, 11)); }
       



        Debug.Log("Adding Skill: " + debugSkills[rnd] + " at value " );
        rnd = Random.Range(0, debugLikes.Count);
        newCriminal.likes.Add(debugLikes[rnd]);
        Debug.Log("Adding like: " + debugLikes[rnd]);

        rnd = Random.Range(0, debugLikes.Count);
        newCriminal.dislikes.Add(debugLikes[rnd]);
        Debug.Log("Adding dislike: " + debugLikes[rnd]);
    }
}
