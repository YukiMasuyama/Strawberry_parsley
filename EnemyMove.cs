using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {
    public float speed = 1.0f;

    private GameObject Player;
    private Vector3 EnemyMoveDirection;

	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        EnemyMoveDirection.x = Player.transform.position.x - gameObject.transform.position.x;
        EnemyMoveDirection.z = Player.transform.position.z - gameObject.transform.position.z;

        gameObject.transform.position += EnemyMoveDirection.normalized * speed * Time.deltaTime;
	}
}
