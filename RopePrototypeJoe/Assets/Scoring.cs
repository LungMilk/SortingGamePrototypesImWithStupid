using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{

    Collectables contact;
    public TextMeshProUGUI Score;
    float x;

    public List<ImageGenerator> scoringConditions;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Score: " + x;
        if (Input.GetMouseButtonDown(0))
        {
            for (int i = 0; i < scoringConditions.Count; i++)
            {
                print(scoringConditions[i].type);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        contact = collision.GetComponent<Collectables>();
        if (listChecker())
        {
            //i handled it wrong
            x++;
        }else { x--; print("Dont submit the incorrect shapes"); } 
        Destroy(collision.gameObject);
        //how can i access specific varaibles of the collider object
    }

    bool listChecker()
    {
        int checker = 0;
        for (int i = 0; i < scoringConditions.Count; i++)
        {
            //always stops at the first shape and doesnt account for any in the list
            if (contact.type == scoringConditions[i].type)
            {
                //hopefully add something that shows the incrementation.
                checker++;
            }
            else
            {

            }
            
        }
        if (checker > 0) { return true; } else { return false; }
    }
}
