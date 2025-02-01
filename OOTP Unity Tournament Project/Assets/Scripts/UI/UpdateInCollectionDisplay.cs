using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UpdateInCollectionDisplay : MonoBehaviour
{
    public static UpdateInCollectionDisplay Instance {get; private set;}
    
    [SerializeField] private GameObject inCollectionDisplay;

    private void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("There is more than one Collection Updater" + Instance);
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }
   

    public void UpdateCollectionObjectDisplay(int cardID)
    {
        //check the collection to see if the cardID is in it
        if(JsonReader.Instance.collectionList.Contains(cardID))
        {
            inCollectionDisplay.gameObject.SetActive(true);
        }
        else{ inCollectionDisplay.gameObject.SetActive(false);}
    }
}
