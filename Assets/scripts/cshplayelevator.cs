using UnityEngine;

public class cshplayelevator : MonoBehaviour
{
    public float moveAmount = 5.5f;  // �� ���� �̵��� �Ÿ�
    private CharacterController characterController;
    private Vector3 targetPosition;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();  // CharacterController ������Ʈ�� �����ɴϴ�.
    }

    // �÷��̾ ���� �̵���Ű�� �Լ� (���� �̵�ó��)
    public void MovePlayerUp()
    {
        // CharacterController�� ��Ȱ��ȭ�Ͽ� �浹�� �ӽ÷� ����
        characterController.enabled = false;

        // ��ǥ ��ġ ���
        targetPosition = transform.position + new Vector3(0, moveAmount, 0);

        // transform���� ���� �̵�
        transform.position = targetPosition;

        // �̵� �� CharacterController�� �ٽ� Ȱ��ȭ
        characterController.enabled = true;

        Debug.Log("Moved up to: " + transform.position.y);  // ����� �α� �߰�
    }

    // �÷��̾ �Ʒ��� �̵���Ű�� �Լ� (���� �̵�ó��)
    public void MovePlayerDown()
    {
        // CharacterController�� ��Ȱ��ȭ�Ͽ� �浹�� �ӽ÷� ����
        characterController.enabled = false;

        // ��ǥ ��ġ ���
        targetPosition = transform.position - new Vector3(0, moveAmount, 0);

        // transform���� ���� �̵�
        transform.position = targetPosition;

        // �̵� �� CharacterController�� �ٽ� Ȱ��ȭ
        characterController.enabled = true;

        Debug.Log("Moved down to: " + transform.position.y);  // ����� �α� �߰�
    }
}
