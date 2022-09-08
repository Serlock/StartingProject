using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform obstackle;
    Vector3 position;

    // This part is not done yet
    void Update()
    {
        position = obstackle.transform.position;

        if (position.x <= 5.5)
        {
            if(position.x >= -5)
            {
                position.x -= 0.05f;
            }
        }
        else if (position.x >= -5.5)
        {
            if (position.x <= 5)
            {
                position.x += 0.05f;
            }
        }

        obstackle.transform.position = position;
    }
}
