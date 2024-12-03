using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DirtyPlateCollectionbin : MonoBehaviour
{
    DirtyPlate contact;
    public DirtyPlateSpawn spawn;

    //ConveyorBeltSpawn collectBeltSpawn;

    public TextMeshProUGUI dirtyPlateWarning;
    // Start is called before the first frame update
    private void Start()
    {
        dirtyPlateWarning.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (spawn.platesInRotation == spawn.plateLimit)
        { dirtyPlateWarning.gameObject.SetActive(true);
            print("plate warning active");
        }
        else if (spawn.platesInRotation < spawn.plateLimit){
            print("no warning");
            dirtyPlateWarning.gameObject.SetActive(false); }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("contact with " + this.name);
        contact = collision.GetComponent<DirtyPlate>();
        if (contact.type == -1)
        {
            Destroy(collision.gameObject);
            spawn.platesInRotation--;
            //probably need some communication with the collectable spawner to also gate its progress
        }

        //i wna tthere to be a limit on plates generated that is modified via plates collected. so there is a max of plate
    }
}
