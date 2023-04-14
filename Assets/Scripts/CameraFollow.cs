using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // プレイヤーのTransformコンポーネントへの参照
    public Vector3 offset; // カメラとプレイヤーとのオフセット距離

    // Update is called once per frame
    void LateUpdate()
    {
        // プレイヤーの位置にオフセットを加算して、カメラの新しい位置を計算
        Vector3 newPosition = player.position + offset;

        // カメラの位置を新しい位置に更新
        transform.position = newPosition;
    }
}
