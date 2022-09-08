using System;
using UnityEngine;

public class Point : MonoBehaviour
{
    public Transform player;
    public Transform quad;
    public GameObject quadObject;
    int score = 0;

    // Update is called once per frame
    void Update()
    {
        if (quad.position.z - player.position.z < 2)
        {
            if (player.position.y <= quad.position.y + 1.5 && player.position.y >= quad.position.y
                && player.position.x >= quad.position.x - 2 && player.position.x <= quad.position.x + 2
                && quad.position.z - player.position.z > -1)
            {
                Debug.Log(quadObject.transform.GetChild(0).GetChild(0).name);
                score = Convert.ToInt32(quadObject.transform.GetChild(0).GetChild(0).name);
                FindObjectOfType<Score>().ChangeScore(score);

                Destroy(quadObject);
                Debug.Log("Quad destroyed");
            }
        }
    }
}
