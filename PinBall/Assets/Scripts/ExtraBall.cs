using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBall : MonoBehaviour
{
    [SerializeField] private Transform ballSpawn;
    [SerializeField] private GameObject extraBallPrefab;

    private GameObject extraBall = null;

    private void OnTriggerEnter(Collider other)
    {
        if(extraBall == null)
        {
            extraBall = Instantiate(extraBallPrefab);
            extraBall.transform.position = ballSpawn.position;
        }
    }

}
