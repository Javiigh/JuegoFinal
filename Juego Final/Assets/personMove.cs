using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personMove : MonoBehaviour
{
    void Start()
    {
        transform.localScale += new Vector3(1.5f, 1.5f, 1.5f);
    }

    void Update()
    {
        gameObject.transform.Rotate(0, Time.deltaTime * 50, 0);
    }
}
