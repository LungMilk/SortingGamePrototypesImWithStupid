using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeDetection : MonoBehaviour
{
    public Collider2D Ropecolliders;
    public SpriteRenderer Ropesprites;
    // Start is called before the first frame update
    void Start()
    {
        Ropecolliders = GetComponent<Collider2D>();
        Ropesprites = GetComponent<SpriteRenderer>();
        Ropesprites.color = Color.white;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        Ropesprites.color = Color.red;
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("collision");
        Ropesprites.color = Color.green;
    }

}
