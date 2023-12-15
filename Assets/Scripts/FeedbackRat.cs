/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackRat : MonoBehaviour

{
    public GameObject Feedback_Rat;
    public bool ratCheck = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        ratCheck = true;

        if (other.tag == "Player")
        {
            Debug.Log("Player entered rat area");
        }
    }
    // Start is called before the first frame update
    public void GetFindRat()
    {
        Feedback_Rat = GameObject.FindGameObjectsWithTag("FeedbackRat");
        Debug.Log("FeedbackRat");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/