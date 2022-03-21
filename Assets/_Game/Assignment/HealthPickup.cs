using DefaultNamespace.ScriptableEvents;
using UnityEngine;
using Variables;

public class HealthPickup : MonoBehaviour
{
    [SerializeField] private ScriptableEventIntReference _onHealthPickupEvent;
    [SerializeField] private IntReference _healValue;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (string.Equals(other.gameObject.tag, "Player"))
        {
            Debug.Log("Collected health pickup");
            _onHealthPickupEvent.Raise(_healValue);
            Destroy(gameObject);
        }
    }
}
