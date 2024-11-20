using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public List<Sprite> colors;
    public SpriteRenderer spriteRenderer;

    public int type;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        SetImages();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetImages()
    {
        //def need a bag randomizer
        int index = Random.Range(0, colors.Count);
        spriteRenderer.sprite = colors[index];
        type = index;
    }
}
