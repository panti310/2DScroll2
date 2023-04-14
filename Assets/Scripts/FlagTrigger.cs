using UnityEngine;

public class FlagTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // プレイヤーが旗に触れたときの処理をここに書きます。
            Debug.Log("Game Clear!");
        }
    }
}
