using UnityEngine;

public class cshteleport_plus : MonoBehaviour
{
    public Transform player;            // �÷��̾��� Transform
    public Vector3 teleportPosition;    // �����̵��� ��ġ
    private CharacterController controller;  // CharacterController ����

    private void Start()
    {
        // �÷��̾��� CharacterController ������Ʈ ��������
        controller = player.GetComponent<CharacterController>();
    }

    private void OnMouseDown()
    {
        if (player != null)
        {
            // CharacterController ��Ȱ��ȭ
            if (controller != null)
                controller.enabled = false;

            // �����̵� (transform.position ���)
            player.position = teleportPosition;

            // CharacterController �ٽ� Ȱ��ȭ
            if (controller != null)
                controller.enabled = true;

           
        }
    }
}
