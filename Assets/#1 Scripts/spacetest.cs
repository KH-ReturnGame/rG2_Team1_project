using UnityEngine;

public class spacetest : MonoBehaviour
{
    // Update 함수는 매 프레임마다 호출됩니다.
    void Update()
    {
        // 스페이스 바 키가 눌렸는지 확인합니다.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 스페이스 바가 눌렸으면 콘솔 창에 메시지를 출력합니다.
            Debug.Log("스페이스 바가 눌렸습니다!");
        }
    }
}