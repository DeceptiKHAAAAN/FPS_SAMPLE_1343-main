using UnityEngine;
using UnityEngine.UI;

public class HealthBarLogic : MonoBehaviour
{
    Image healthBarImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBarImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseHealthBar()
    {
        healthBarImage.fillAmount -= .10f;
    }
}
