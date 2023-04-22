using UnityEngine;
public class EnemyMove : MonoBehaviour
{
    [SerializeField] SpriteRenderer Face;
    public int Pos;
    int Offset = 7;
    int Direction;
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
        transform.position = new Vector3(Pos, transform.position.y, 0);
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
    }
}
