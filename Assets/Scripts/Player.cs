using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 8.0f; // ジャンプ力を設定する
    private Rigidbody2D rb; // Rigidbody2Dコンポーネントを格納する変数を追加

    void Start()
    {
        // Rigidbody2Dコンポーネントを取得して格納
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Move(horizontalInput);

        // スペースキーが押されたかどうかを判定し、押されたらジャンプ処理を呼び出す
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Move(float horizontalInput)
    {
        Vector3 currentPosition = transform.position;
        float moveAmount = horizontalInput * speed * Time.deltaTime;
        currentPosition.x += moveAmount;
        transform.position = currentPosition;
    }

    // ジャンプ処理を追加
    void Jump()
    {
        // 上方向にジャンプ力をかけてジャンプさせる
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
    }
}
