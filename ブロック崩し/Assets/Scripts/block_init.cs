using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block_init : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject blockobjprefub;
    public GameObject blocks;
    void Awake()
    {
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                GameObject g = Instantiate(blockobjprefub, blocks.transform);
                g.transform.transform.position = new Vector3(2f + 1f * y, 0.4f, -4.2f + 1.2f * x);
            }
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
