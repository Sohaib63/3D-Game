using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Debug.Log("Score: " + score);
    }

    void OnTriggerEnter(Collider other)
    {
        UnityEngine.Debug.Log("Collider is working");
        if (other.gameObject.tag == "scoreup")
        {
            score++;
        }
    }
}
