using UnityEngine;
using UnityEngine.UI;

public class EnemyUIManager : MonoBehaviour
{
    // REFERENCE the enemies health bar 
    [SerializeField] Slider healthBar;

    // UpdateHealth: This method will update the health bar with the value given
    void UpdateHealth(int health)
    {
        healthBar.value = health;
    }
}
