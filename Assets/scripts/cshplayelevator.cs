using UnityEngine;

public class cshplayelevator : MonoBehaviour
{
    public float moveAmount = 5.5f;  // 한 번에 이동할 거리
    private CharacterController characterController;
    private Vector3 targetPosition;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();  // CharacterController 컴포넌트를 가져옵니다.
    }

    // 플레이어를 위로 이동시키는 함수 (순간 이동처럼)
    public void MovePlayerUp()
    {
        // CharacterController를 비활성화하여 충돌을 임시로 제거
        characterController.enabled = false;

        // 목표 위치 계산
        targetPosition = transform.position + new Vector3(0, moveAmount, 0);

        // transform으로 순간 이동
        transform.position = targetPosition;

        // 이동 후 CharacterController를 다시 활성화
        characterController.enabled = true;

        Debug.Log("Moved up to: " + transform.position.y);  // 디버깅 로그 추가
    }

    // 플레이어를 아래로 이동시키는 함수 (순간 이동처럼)
    public void MovePlayerDown()
    {
        // CharacterController를 비활성화하여 충돌을 임시로 제거
        characterController.enabled = false;

        // 목표 위치 계산
        targetPosition = transform.position - new Vector3(0, moveAmount, 0);

        // transform으로 순간 이동
        transform.position = targetPosition;

        // 이동 후 CharacterController를 다시 활성화
        characterController.enabled = true;

        Debug.Log("Moved down to: " + transform.position.y);  // 디버깅 로그 추가
    }
}
