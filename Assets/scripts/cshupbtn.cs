using UnityEngine;

public class cshupbtn : MonoBehaviour
{
    public GameObject player;  // 플레이어 오브젝트
    private cshplayelevator playerScript;

    private void Start()
    {
        playerScript = player.GetComponent<cshplayelevator>();  // cshplayelevator 스크립트를 참조
    }

    private void OnMouseDown()  // 마우스 좌클릭 시
    {
        if (playerScript != null)
        {
            playerScript.MovePlayerUp();  // 플레이어를 위로 이동
        }
    }
}
