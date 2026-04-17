using UnityEngine;
using UnityEngine.Events;

public class RefillPanelLogic : MonoBehaviour
{
    [SerializeField] UnityEvent<bool> RefillOn;
    private void OnEnable()
    {
        RefillOn.Invoke(true);
    }
    private void OnDisable()
    {
        RefillOn.Invoke(false);
    }
    void Update()
    {
        //if (Input.GetButtonDown("Interact"))
        //{
        //    OnRefill.Invoke();
        //}
    }
}
