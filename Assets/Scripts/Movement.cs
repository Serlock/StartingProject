using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform obstackle;
    public Transform point;
    Vector3 position;
    string mothodName = "";

    // This part is not done yet
    void Update()
    {
        if (obstackle.transform.position.x >= -5.5 && obstackle.transform.position.x <= -5)
        {
            mothodName = "MoveRight";
        }

        if (obstackle.transform.position.x > 5 && obstackle.transform.position.x <= 5.5)
        {
            mothodName = "MoveLeft";
        }

        Invoke(mothodName, 0.01f);
    }

    void MoveLeft()
    {
        position = obstackle.transform.position;
        position.x -= 0.01f;
        obstackle.transform.position = position;
        position.y = 3.5f;

        if (point)
        {
            point.transform.position = position;
        }
    }

    void MoveRight()
    {
        position = obstackle.transform.position;
        position.x += 0.01f;
        obstackle.transform.position = position;
        position.y = 3.5f;

        if (point)
        {
            point.transform.position = position;
        }

    }
}
