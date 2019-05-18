using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Google2u;
public class CriminalManager : MonoBehaviour
{
    public GameObject databaseOfProfiles,dossierPrefab;
    public Transform dossierFocusSpot, desktopSpot;
    public Dossier focusedDossier;
    public List<culprit>  criminalMasterList;
    
    // Start is called before the first frame update
    void Start()
    {
        criminalMasterList = new List<culprit>();
        foreach (ProfilesRow el in databaseOfProfiles.GetComponent<Profiles>().Rows)
        { criminalMasterList.Add(CreateCriminal(el)); }



    }

    // Update is called once per frame
    void Update()
    {

        if (focusedDossier != null)
        {
            if ( Vector3.Distance(focusedDossier.transform.position, dossierFocusSpot.position) > 0)
            {

                focusedDossier.transform.position = Vector3.MoveTowards(focusedDossier.transform.position, dossierFocusSpot.position, 1 * Time.deltaTime);
                focusedDossier.transform.rotation = Quaternion.Slerp(focusedDossier.transform.rotation, dossierFocusSpot.rotation, 5 * Time.deltaTime);

            }
            else { }
        }
        
    }


    public culprit CreateCriminal(ProfilesRow criminalData)
    {
        culprit newCriminal;
        newCriminal.likes = new List<string>();
        newCriminal.dislikes = new List<string>();
        newCriminal.skillList = new Dictionary<string, int>();
        
      //  newCriminal.skillList.Add(debugSkills[rnd], Random.Range(-10, 11));
        newCriminal.skillList.Add(criminalData._Skill_ID_1, Random.Range(-10, 11));
        //newCriminal.skillList.Add(criminalData._Skill_ID_2, Random.Range(-10, 11));
       // newCriminal.skillList.Add(criminalData._Skill_ID_3, Random.Range(-10, 11));

        newCriminal.likes.Add(criminalData._Like_ID_1);
        newCriminal.likes.Add(criminalData._Idle_ID_2);
        newCriminal.likes.Add(criminalData._Idle_ID_3);

        newCriminal.dislikes.Add(criminalData._Dislile_ID_1);
        newCriminal.dislikes.Add(criminalData._Dislile_ID_2);
        newCriminal.dislikes.Add(criminalData._Dislile_ID_3);


        newCriminal.name = criminalData._Name;
        newCriminal.description = criminalData._Description;
        newCriminal.liketext = criminalData._Like_Text;
        newCriminal.disliketext = criminalData._Dislike_Text;
        newCriminal.skilltext = criminalData._Skills_Text;
        Debug.Log(newCriminal.skilltext);
        return newCriminal;
    }




    public void ChangeFocusedDossier(Dossier newFocus)
    {
            if (focusedDossier != null) {

               

            if (focusedDossier == newFocus)
            {
                focusedDossier.ChangeFocus();
                focusedDossier = null;
            }
            else
            {
                focusedDossier.GetComponent<Rigidbody>().isKinematic = false; focusedDossier.ChangeFocus();

                focusedDossier = newFocus;
                focusedDossier.GetComponent<Rigidbody>().isKinematic = true;
                newFocus.ChangeFocus();
            }
    }else{ focusedDossier = newFocus;
                focusedDossier.GetComponent<Rigidbody>().isKinematic = true;
                newFocus.ChangeFocus();}
    }

}
