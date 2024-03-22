using UnityEngine;

public class TerminalTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider one)
    {
        if (one.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().Win();
        }
    }
}
