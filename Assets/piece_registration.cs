using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class piece_registration : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;

    public static GameObject[,] cubes = new GameObject[14, 23];

    public static GameObject[,] minicubes = new GameObject[4, 2];

    //ピースの形
    enum Types {I = 1, O, S, Z, J, L, T};

    //ピース登録用
    public void Stationery_piece(int x1, int y1, int x2, int y2,
                          int x3, int y3, int x4, int y4,
                          bool exist, int piece_type)
    {
        cubes[x1, y1].GetComponent<cube>().c_swich = exist;
        cubes[x2, y2].GetComponent<cube>().c_swich = exist;
        cubes[x3, y3].GetComponent<cube>().c_swich = exist;
        cubes[x4, y4].GetComponent<cube>().c_swich = exist;

        cubes[x1, y1].GetComponent<cube>().cube_type = piece_type;
        cubes[x2, y2].GetComponent<cube>().cube_type = piece_type;
        cubes[x3, y3].GetComponent<cube>().cube_type = piece_type;
        cubes[x4, y4].GetComponent<cube>().cube_type = piece_type;
    }

    //ピースの各角度の登録
    void RotateRegistration(int RR_x, int RR_y, Action action0, Action action90, Action action270, Action action180)
    {
        switch(cubes[RR_x,RR_y].GetComponent<cube>().cube_rotate_type)
        {
            // 0°
            case 1:

                action0();

                break;

            // 90°
            case 2:

                action90();

                break;

            // -90°
            case 3:

                action270();

                break;

            // 180°
            case 4:

                action180();

                break;
        }
    }

    //ピースの登録
    void TypeRegistration(int TR_x, int TR_y, bool transfer)
    {
        switch(cubes[TR_x, TR_y].GetComponent<cube>().cube_type)
        {
            case (int)Types.I:

                RotateRegistration(TR_x, TR_y,
                    () => { Stationery_piece(TR_x - 2, TR_y, TR_x - 1, TR_y, TR_x, TR_y, TR_x + 1, TR_y, transfer, 1); },
                    () => { Stationery_piece(TR_x, TR_y + 2, TR_x, TR_y + 1, TR_x, TR_y, TR_x, TR_y - 1, transfer, 1); },
                    () => { Stationery_piece(TR_x, TR_y + 1, TR_x, TR_y, TR_x, TR_y - 1, TR_x, TR_y - 2, transfer, 1); },
                    () => { Stationery_piece(TR_x - 1, TR_y, TR_x, TR_y, TR_x + 1, TR_y, TR_x + 2, TR_y, transfer, 1); });

                break;

            case (int)Types.O:

                RotateRegistration(TR_x, TR_y,
                    () => { Stationery_piece(TR_x, TR_y + 1, TR_x + 1, TR_y + 1, TR_x, TR_y, TR_x + 1, TR_y, transfer, 2); },
                    () => { Stationery_piece(TR_x, TR_y, TR_x + 1, TR_y, TR_x, TR_y - 1, TR_x + 1, TR_y - 1, transfer, 2); },
                    () => { Stationery_piece(TR_x - 1, TR_y + 1, TR_x, TR_y + 1, TR_x - 1, TR_y, TR_x, TR_y, transfer, 2); },
                    () => { Stationery_piece(TR_x - 1, TR_y, TR_x, TR_y, TR_x - 1, TR_y - 1, TR_x, TR_y - 1, transfer, 2); });

                break;

            case (int)Types.S:

                RotateRegistration(TR_x, TR_y,
                    () => { Stationery_piece(TR_x, TR_y + 1, TR_x + 1, TR_y + 1, TR_x - 1, TR_y, TR_x, TR_y, transfer, 3); },
                    () => { Stationery_piece(TR_x, TR_y + 1, TR_x, TR_y, TR_x + 1, TR_y, TR_x + 1, TR_y - 1, transfer, 3); },
                    () => { Stationery_piece(TR_x - 1, TR_y + 1, TR_x - 1, TR_y, TR_x, TR_y, TR_x, TR_y - 1, transfer, 3); },
                    () => { Stationery_piece(TR_x + 1, TR_y, TR_x, TR_y, TR_x, TR_y - 1, TR_x - 1, TR_y - 1, transfer, 3); });

                break;

            case (int)Types.Z:

                RotateRegistration(TR_x, TR_y,
                    () => { Stationery_piece(TR_x - 1, TR_y + 1, TR_x, TR_y + 1, TR_x, TR_y, TR_x + 1, TR_y, transfer, 4); },
                    () => { Stationery_piece(TR_x + 1, TR_y + 1, TR_x + 1, TR_y, TR_x, TR_y, TR_x, TR_y - 1, transfer, 4); },
                    () => { Stationery_piece(TR_x, TR_y + 1, TR_x, TR_y, TR_x - 1, TR_y, TR_x - 1, TR_y - 1, transfer, 4); },
                    () => { Stationery_piece(TR_x - 1, TR_y, TR_x, TR_y, TR_x, TR_y - 1, TR_x + 1, TR_y - 1, transfer, 4); });

                break;

            case (int)Types.J:

                RotateRegistration(TR_x, TR_y,
                    () => { Stationery_piece(TR_x - 1, TR_y + 1, TR_x - 1, TR_y, TR_x, TR_y, TR_x + 1, TR_y, transfer, 5); },
                    () => { Stationery_piece(TR_x, TR_y + 1, TR_x + 1, TR_y + 1, TR_x, TR_y, TR_x, TR_y - 1, transfer, 5); },
                    () => { Stationery_piece(TR_x, TR_y + 1, TR_x, TR_y, TR_x - 1, TR_y - 1, TR_x, TR_y - 1, transfer, 5); },
                    () => { Stationery_piece(TR_x - 1, TR_y, TR_x, TR_y, TR_x + 1, TR_y, TR_x + 1, TR_y - 1, transfer, 5); });

                break;

            case (int)Types.L:

                RotateRegistration(TR_x, TR_y,
                    () => { Stationery_piece(TR_x + 1, TR_y + 1, TR_x - 1, TR_y, TR_x, TR_y, TR_x + 1, TR_y, transfer, 6); },
                    () => { Stationery_piece(TR_x, TR_y + 1, TR_x, TR_y, TR_x, TR_y - 1, TR_x + 1, TR_y - 1, transfer, 6); },
                    () => { Stationery_piece(TR_x - 1, TR_y + 1, TR_x, TR_y + 1, TR_x, TR_y, TR_x, TR_y - 1, transfer, 6); },
                    () => { Stationery_piece(TR_x - 1, TR_y, TR_x, TR_y, TR_x + 1, TR_y, TR_x - 1, TR_y - 1, transfer, 6); });

                break;

            case (int)Types.T:

                RotateRegistration(TR_x, TR_y,
                    () => { Stationery_piece(TR_x, TR_y + 1, TR_x - 1, TR_y, TR_x, TR_y, TR_x + 1, TR_y, transfer, 7); },
                    () => { Stationery_piece(TR_x, TR_y + 1, TR_x, TR_y, TR_x + 1, TR_y, TR_x, TR_y - 1, transfer, 7); },
                    () => { Stationery_piece(TR_x, TR_y + 1, TR_x - 1, TR_y, TR_x, TR_y, TR_x, TR_y - 1, transfer, 7); },
                    () => { Stationery_piece(TR_x - 1, TR_y, TR_x, TR_y, TR_x + 1, TR_y, TR_x, TR_y - 1, transfer, 7); });

                break;
        }
    }

    //ピース呼び出し用
    void BlockType(int BT_x, int BT_y, bool rewrite)
    {
        if(cubes[BT_x, BT_y].GetComponent<cube>().control_cube == true)
        {
            TypeRegistration(BT_x, BT_y, rewrite);
        }
    }


    void Awake ()
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
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
