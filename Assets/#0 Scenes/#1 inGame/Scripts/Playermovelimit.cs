using UnityEngine;

public class Playermovelimit : MonoBehaviour
{

    void Update()
    { 
        float h = Input.GetAxis("Horizontal");

        // 현재 위치에 h 방향으로 이동 계산
        Vector3 pos = transform.position;
        

        // 좌우 범위 제한 
        pos.x = Mathf.Clamp(pos.x, -6.24f, 4.26f);

        // 위치 적용
        transform.position = pos;

    }
}
