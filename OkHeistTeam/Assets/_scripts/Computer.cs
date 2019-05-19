using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    public CriminalManager criminalManager;
    public int type; //0 computer 1 pickedpile 2 phone
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        if (type == 0)
        { criminalManager.MoveCamera(); }
        if (type == 1)
        { criminalManager.ChooseCriminal(); }
        if (type == 2)
        { criminalManager.ChooseCriminal(); }
    }

}
