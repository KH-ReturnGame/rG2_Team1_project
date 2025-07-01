using UnityEngine;

public class Move : MonoBehaviour
{
    private void Awake()
    {
        transform.position += Vector3.right * 1;
    }
}