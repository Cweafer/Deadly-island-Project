using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questView : MonoBehaviour {

    //public GameObject[] quests;
    public List<GameObject> quests = new List<GameObject>();
    public GameObject canvas;

    public void addQuest(GameObject currentQuest)
    {
        if (!quests.Contains(currentQuest))
            quests.Add(currentQuest);
    }
	
	// Update is called once per frame
	void Update () {
	//	if (GlobalVariables.collected == true)
   //     {
    //        addQuest();       
   //     }
	}
}
