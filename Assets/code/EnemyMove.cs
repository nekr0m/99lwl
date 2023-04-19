using UnityEngine;
public class EnemyMove : MonoBehaviour
{
    [SerializeField] Manadger Man;
    [SerializeField] SpriteRenderer Face;
    public int Pos;
    int Offset = 7;
    int Direction;
    float b;
    void OnEnable()
    {
        int a = Random.Range(0, 2);
        if (a == 0)
        {
            Direction = -1;
            Face.flipX = true;
        }
        if (a == 1)
        {
            Direction = 1;
            Face.flipX = false;
        }
        transform.position = new Vector3(Pos, 0, 0);
        b = 0.1f;
    }
    void Update()
    {
        transform.position += new Vector3(Direction * Time.deltaTime, 0, 0);
        if (Offset < transform.position.x)
        {
            Direction = -1;
            Face.flipX = true;
        }
        if (-Offset > transform.position.x)
        {
            Direction = 1;
            Face.flipX = false;
        }
        if (b > 0)
        {
            b -= Time.deltaTime;
            if (b <= 0) Man.aud.PlayMuz(1);
        }
    }
    void OnDisable()
    {
        Man.aud.PlayMuz(0);
    }
}
