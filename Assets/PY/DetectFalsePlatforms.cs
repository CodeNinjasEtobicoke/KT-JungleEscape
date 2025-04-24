using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{

    void Update()
    {
        float dist = 2f;

        Vector3 pos = transform.position;
        pos.y -= 0.5f;

        bool hit = Physics.Raycast(pos, transform.forward, dist, 1 << 8);
        Debug.DrawRay(pos, transform.forward * dist, Color.red);

        if (hit == true)
        {
            Debug.LogWarning("Be careful");
        }
        else
        {
            Debug.Log("All clear");
        }
        
    }
}
