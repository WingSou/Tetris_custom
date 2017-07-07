using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    [SerializeField]
    public Material[] _material;

    //箱があるか無いか
    public bool c_swich;
    //ピースのタイプ
    public int cube_type;
    //ピースの角度
    public int cube_rotate_type;
    //基準点か判断
    public bool control_cube;
    //連鎖箱かどうか
    public bool combo_cube;
    //連鎖方向
    public bool combo_rotate;

    //コンボが縦か、横か
    void Combo()
    {
        switch(combo_rotate)
        {
            case true:

                GetComponent<Renderer>().material = _material[1];

                break;

            case false:

                GetComponent<Renderer>().material = _material[2];

                break;
        }
    }

    //コンボ箱かどうか
    void ComboDecision()
    {
        switch (combo_cube)
        {
            case true:

                Combo();

                break;

            case false:

                GetComponent<Renderer>().material = _material[0];

                break;
        }
    }

    void Awake ()
    {
        c_swich = false;
        cube_type = 0;
        cube_rotate_type = 0;
        control_cube = false;
        combo_cube = false;
        combo_rotate = true;//trueは縦、falseは横
	}
	
	void Update ()
    {
		switch(c_swich)
        {
            //ブロックがある
            case true:

                ComboDecision();

                break;

            //ブロックが無い
            case false:

                GetComponent<Renderer>().material.color = Color.white;
                cube_type = 0;

                break;
        }
	}
}
