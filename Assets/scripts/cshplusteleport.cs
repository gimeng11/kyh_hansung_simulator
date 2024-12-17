using UnityEngine;

public class cshplusteleport : MonoBehaviour
{
    public Transform player;  // 플레이어의 Transform을 지정
    public Vector3 teleportPosition;  // 순간이동할 위치

    private void OnMouseDown()
    {
        if (player != null)
        {
            player.position = teleportPosition;  // 플레이어를 특정 위치로 이동
        }
    }
}
