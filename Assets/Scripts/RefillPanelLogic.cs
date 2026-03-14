using UnityEngine;
using UnityEngine.Events;

public class RefillPanelLogic : MonoBehaviour
{
    [SerializeField] UnityEvent OnRefill;
    void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            OnRefill.Invoke();
        }
    }
}
