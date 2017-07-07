using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrangement : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;

    [SerializeField]
    private GameObject minicube;

    public static GameObject[,] cubes = new GameObject[14, 23];

    public static GameObject[,] minicubes = new GameObject[2, 4];

    void Start ()
    {
        for (int i = 0; i < 14; i++)
        {
            for (int r = 0; r < 23; r++)
            {                                    //6,19 中心？
                transform.position = new Vector3(i, r, 0);
                cubes[i, r] = Instantiate(cube, transform.position, transform.rotation);
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int r = 0; r < 2; r++)
            {                                    //6,19 中心？
                transform.position = new Vector3(14 + i, 23 + r, 0);
                minicubes[i, r] = Instantiate(cube, transform.position, transform.rotation);
            }
        }

        //壁生成
        for (int i = 0; i < 21; i++)
        {
            cubes[0, i].GetComponent<cube>().c_swich = true;
            cubes[1, i].GetComponent<cube>().c_swich = true;
            cubes[12, i].GetComponent<cube>().c_swich = true;
            cubes[13, i].GetComponent<cube>().c_swich = true;
        }

        ////底生成
        for (int i = 2; i < 12; i++)
        {
            cubes[i, 0].GetComponent<cube>().c_swich = true;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
