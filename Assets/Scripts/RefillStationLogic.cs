using UnityEngine;
using UnityEngine.Events;

public class RefillStationLogic : MonoBehaviour
{
    [SerializeField] UnityEvent OnRefillEnter;
    [SerializeField] UnityEvent OnRefillExit;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<FPSController>() != null)
        {
            Debug.Log("Interactable Yes");
            OnRefillEnter.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<FPSController>() != null)
        {
            OnRefillExit.Invoke();
        }
    }
}
