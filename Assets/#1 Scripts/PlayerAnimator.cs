using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
      private Animator animator_;

    void Awake()
    {
        animator_ = GetComponent<Animator>();
    }

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator_.SetBool("isJump", true);
        }
        else
        {
            animator_.SetBool("isJump", false);
        }

    }
}

