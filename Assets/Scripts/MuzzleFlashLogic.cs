using UnityEngine;

public class MuzzleFlashLogic : MonoBehaviour
{
    [SerializeField] GameObject endOfBarrel;
    ParticleSystem ps;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = endOfBarrel.transform.position;
        transform.rotation = endOfBarrel.transform.rotation;
    }

    public void DoEffect()
    {
        ps.Play();
    }
}
