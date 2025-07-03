using UnityEngine;
using UnityEngine.UI; //UI쓴대요
using System.Collections;
using Unity.VisualScripting;
using System.Security.Cryptography.X509Certificates;

public class PlayerTest_Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    SpriteRenderer spriteRenderer;
    Animator anim;
    public float AttackCoolDown = 0.8f;
    BoxCollider2D boxCollider2D;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        //moveX 초기화
        int moveX = 0;


        if (Input.GetKey(KeyCode.D) && anim.GetBool("isAttack") == false)
        {
            spriteRenderer.flipX = false;
            moveX = 1;
        }

        else if (Input.GetKey(KeyCode.A) && anim.GetBool("isAttack") == false)
        {
            spriteRenderer.flipX = true;
            moveX = -1;
        }
        // 이동
        Vector3 move = new Vector3(moveX, 0, 0) * moveSpeed * Time.deltaTime;
        transform.Translate(move, Space.World); //move는 이동량

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -5.66f, 3.69f); // 위치의 수치 제한
        transform.position = pos;

        // 공격
        if (Input.GetKeyDown(KeyCode.K) && anim.GetBool("isAttack") == false)
        {
            boxCollider2D.size = new Vector2(0.15f, 0.16f);
            transform.localScale = new Vector3(6, 6, 6);

            StartCoroutine(AttackCoroutine(AttackCoolDown));

        }

    }
    IEnumerator AttackCoroutine(float AttackCoolDown2)
    {
        anim.SetBool("isAttack", true);
        yield return new WaitForSeconds(AttackCoolDown2);

        transform.localScale = new Vector3(1, 1, 1);
        boxCollider2D.size = new Vector2(1.0f, 1.0f);
        anim.SetBool("isAttack", false);

    }
}
