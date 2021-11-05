using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSphere : MonoBehaviour
{
    public float RADIUS = 5.0f;      // 円運動の半径
    // 毎フレーム実行される処理
    void Update()
    {
        // x,y,zの座標を計算する
        Vector3 pos = new Vector3
            (
                Mathf.Sin(Time.time) * RADIUS,  // X軸の移動量計算(-20~20)
                0,                              // Y軸は移動なし
                Mathf.Cos(Time.time) * RADIUS   // Z軸の移動量計算(-20~20)
            );
        // x,y,zの座標を設定する
        transform.position = pos;
    }
}