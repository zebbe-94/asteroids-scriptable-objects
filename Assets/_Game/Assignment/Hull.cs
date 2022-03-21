using DefaultNamespace.ScriptableEvents;
using UnityEngine;
using Variables;

namespace Ship
{
    public class Hull : MonoBehaviour
    {
        //[SerializeField] private IntVariable _health;
        [SerializeField] private ScriptableEventIntReference _onHealthChangedEvent;
        [SerializeField] private IntReference _healthRef;
        [SerializeField] private IntObservable _healthObservable;
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (string.Equals(other.gameObject.tag, "Asteroid"))
            {
                Debug.Log("Hull collided with Asteroid");
                ApplyHealth(-1);
            }
        }

        public void ApplyHealth(int value)
        {
            _healthObservable.ApplyChange(value);
        }
        public void ApplyHealth(IntReference valueRef)
        {
            _healthObservable.ApplyChange(valueRef.GetValue());
        }
    }
}
