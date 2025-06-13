using UnityEngine;

public class player : MonoBehaviour
{
    public player enemy;
    public int maxhp = 100;
    public int currenthp;

    public string _name;
    void Start()
    {
        currenthp = maxhp;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)&&_name=="player1")
        {
            if (enemy != null)
            {
                enemy.TakeDamage(10);
            }
        }
        else if (Input.GetKeyDown(KeyCode.F)&&_name=="player2")
        {
            if (enemy != null)
            {
                enemy.TakeDamage(10);
            }
        }
    }
    public void TakeDamage(int damage)
    {
        currenthp -= damage;
        Debug.Log(_name+" : "+currenthp);
    }
}

