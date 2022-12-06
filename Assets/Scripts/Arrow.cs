using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject gameManager;
    
    void Start()
    {
        gameManager = GameObject.Find("GameManger");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y<-5.0f)
        {
            gameManager.GetComponent<GameManager>().IncreaseScore();
            Destroy(gameObject);  
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
