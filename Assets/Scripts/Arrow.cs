using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject gameManager;
    bool IsIncreaseScore = false;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManger");
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y<-6.5 && IsIncreaseScore == false)
        {
            gameManager.GetComponent<GameManager>().IncreaseScore();

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
