using UnityEngine;
using Cinemachine;

public class ScreenShake : MonoBehaviour
{
    bool isShaking = false;
    float timeAfterShake = 0;
    [SerializeField] CinemachineVirtualCamera vcam;

    [ContextMenu("Start Shake")]

    private void Update()
    {
        if (isShaking)
            timeAfterShake += Time.deltaTime;
        if (timeAfterShake > 0.1)
            EndShake();
    }
    public void StartShake()
    {
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 10;
        isShaking = true;
    }
    [ContextMenu("End Shake")]
    public void EndShake()
    {
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0;
        isShaking = false;
        timeAfterShake = 0;
    }
}
