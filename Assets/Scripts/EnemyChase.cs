using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform player;
    public float detectionRadius = 5f;
    public float stopChasingRadius = 10f;
    public float moveSpeed = 3f;
    private bool isChasing;

    void Update()
    {
        if (player == null) return;
        float distance = Vector3.Distance(transform.position, player.position);
        if (!isChasing && distance <= detectionRadius) isChasing = true;
        if (isChasing && distance > stopChasingRadius) isChasing = false;
        if (!isChasing) return;

        Vector3 target = new Vector3(player.position.x, transform.position.y, player.position.z);
        transform.position = Vector3.MoveTowards(transform.position, target, moveSpeed * Time.deltaTime);
    }
}
