using UnityEngine;

public class cshteleport_plus : MonoBehaviour
{
    public Transform player;            // 플레이어의 Transform
    public Vector3 teleportPosition;    // 순간이동할 위치
    private CharacterController controller;  // CharacterController 참조

    private void Start()
    {
        // 플레이어의 CharacterController 컴포넌트 가져오기
        controller = player.GetComponent<CharacterController>();
    }

    private void OnMouseDown()
    {
        if (player != null)
        {
            // CharacterController 비활성화
            if (controller != null)
                controller.enabled = false;

            // 순간이동 (transform.position 사용)
            player.position = teleportPosition;

            // CharacterController 다시 활성화
            if (controller != null)
                controller.enabled = true;

           
        }
    }
}
