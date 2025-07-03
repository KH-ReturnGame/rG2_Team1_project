using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
      private Animator animator_;

    void Awake()
    {
        animator_ = GetComponent<Animator>();
    }
// 애니메이션 작동 코드
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            animator_.SetBool("isRun", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator_.SetBool("isRun", true);
        }
        else
        {
            animator_.SetBool("isRun", false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            animator_.SetBool("isJump", true);
        }
        else
        {
            animator_.SetBool("isJump", false);
        }

    }
}

