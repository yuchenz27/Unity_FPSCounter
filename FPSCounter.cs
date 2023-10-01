using UnityEngine;
using TMPro;

public class FPSCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _fpsText;

    private float _accumulatedTime = 0;

    private int _frameCount;

    private const float UPDATE_INTERVAL = 0.2f;

    private void OnEnable()
    {
        _fpsText.text = "FPS: 60";
        _accumulatedTime = 0f;
        _frameCount = 0;
    }

    private void Update()
    {
        _accumulatedTime += Time.deltaTime;
        _frameCount++;
        if (_accumulatedTime > UPDATE_INTERVAL)
        {
            int fps = Mathf.RoundToInt(_frameCount / _accumulatedTime);
            _fpsText.text = "FPS: " + fps.ToString();

            _accumulatedTime = 0f;
            _frameCount = 0;
        }
    }
}
