using UnityEngine;

public class cshdownbtn : MonoBehaviour
{
    public GameObject player;  // �÷��̾� ������Ʈ
    private cshplayelevator playerScript;

    private void Start()
    {
        playerScript = player.GetComponent<cshplayelevator>();  // cshplayelevator ��ũ��Ʈ�� ����
    }

    private void OnMouseDown()  // ���콺 ��Ŭ�� ��
    {
        if (playerScript != null)
        {
            playerScript.MovePlayerDown();  // �÷��̾ �Ʒ��� �̵�
        }
    }
}
