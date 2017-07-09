using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrangement : MonoBehaviour
{
    void Start ()
    {
        //壁生成(ピース登録用関数流用)
        for (int i = 0; i < 21; i++)
        {
            GetComponent<piece_registration>().Stationery_piece(0, i, 1, i, 12, i, 13, i, true, 0);
        }

        //底生成(関数流用の関係上、一部再定義)
        for (int i = 1; i < 12; i = i + 4)
        {
            GetComponent<piece_registration>().Stationery_piece(i, 0, i + 1, 0, i + 2, 0, i + 3, 0, true, 0);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
