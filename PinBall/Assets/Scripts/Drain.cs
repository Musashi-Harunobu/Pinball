using UnityEngine;

public class Drain : MonoBehaviour
{
    [SerializeField] private Transform ballSpawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainBall"))
        {
            if (Global.BallCount > 1)
            {
                Global.BallCount -= 1;

                Instantiate(other.gameObject).transform.position = ballSpawn.position;
            }
            else
            {
                GameObject.FindObjectOfType<Global>().GameOver();
            }
        }
        Destroy(other.gameObject);
    }
}

