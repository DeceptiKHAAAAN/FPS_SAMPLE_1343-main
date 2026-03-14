using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] Image healthBar;
    [SerializeField] TMP_Text currentAmmoText;
    [SerializeField] TMP_Text maxAmmoText;

    FPSController player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<FPSController>();
    }

    public void UpdateAmmo(int currentAmmo, int maxAmmo)
    {
        currentAmmoText.text = currentAmmo.ToString();
        maxAmmoText.text = maxAmmo.ToString();
    }
}
