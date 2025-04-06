using System.Collections;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    State state;
    EnemyPathfinding enemyPathfinding;

    private void Awake()
    {
        enemyPathfinding = GetComponent<EnemyPathfinding>();
        state = State.Roaming;
    }

    private void Start()
    {
        StartCoroutine(RoamingRoutine());
    }

    IEnumerator RoamingRoutine()
    {
        while (state == State.Roaming)
        {
            Vector2 roamPostion = GetRoamingPosition();
            enemyPathfinding.MoveTo(roamPostion);
            yield return new WaitForSeconds(2f);
        }
    }

    Vector2 GetRoamingPosition() => new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;

    enum State
    {
        Roaming
    }
}
