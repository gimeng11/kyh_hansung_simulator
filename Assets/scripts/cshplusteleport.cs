using UnityEngine;

public class cshplusteleport : MonoBehaviour
{
    public Transform player;  // �÷��̾��� Transform�� ����
    public Vector3 teleportPosition;  // �����̵��� ��ġ

    private void OnMouseDown()
    {
        if (player != null)
        {
            player.position = teleportPosition;  // �÷��̾ Ư�� ��ġ�� �̵�
        }
    }
}
