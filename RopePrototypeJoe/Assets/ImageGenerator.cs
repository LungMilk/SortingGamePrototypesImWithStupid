using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ImageGenerator : MonoBehaviour
{
    public List<Sprite> Objects;
    public Image goalPrereq;

    //keep it a float for now but change it to text later so I can read it
    public int type;
    //red,green,blue
    // Start is called before the first frame update
    void Start()
    {
        SetImages();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //doing the same thing with collectables maybe use a derivitive class design structure later
    void SetImages()
    {
        int index = Random.Range(0, Objects.Count);
        goalPrereq.sprite = Objects[index];
        type = index;
    }
}
