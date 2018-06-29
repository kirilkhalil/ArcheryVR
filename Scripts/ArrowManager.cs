using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour {

    public SteamVR_TrackedObject trackedObj; //Viite objektiin josta otetaan kiinni
    public GameObject arrowPrefab; //Viite arrow prefabiin
    private GameObject currentArrow; //Viite tämän hetkiseen kädessä olevaan nuoleen
    
    // Use this for initialization
	void Awake () {
        //trackedObj = GetComponent<SteamVR_TrackedObject>();
    }
	
	// Update is called once per frame
	void Update () {
        LiitaNuoli(); //Varmistetaan että on aina nuoli kädessä.
	}

    public void LiitaNuoli()
    {
        if (currentArrow == null)
        {
            currentArrow = Instantiate(arrowPrefab); //Tekee kopion nuolesta ja liittää sen 
            currentArrow.transform.parent = trackedObj.transform; //Liitetään luotu nuoli oikeaan ohjaimeen
        }
    }
}
