using UnityEngine;

public class CanBeDamaged : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<CanDamage>())
        {
            Debug.Log($"hit! (line: 9 object: {name} component: {this.GetType().ToString()})");
            gameObject.GetComponent<EnemyVariables>().health -= collision.gameObject.GetComponent<CanDamage>().damage[0];

            collision.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
