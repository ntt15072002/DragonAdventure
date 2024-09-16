using UnityEngine;

public class Victory : MonoBehaviour
{
    [SerializeField] private GameObject victoryScreen;
    private void Awake()
    {
        victoryScreen.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            victoryScreen.SetActive(true);
        }
    }
}