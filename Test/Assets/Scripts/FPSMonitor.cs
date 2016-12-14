using UnityEngine;

/// <summary>
/// 帧率监测器
/// </summary>
public class FPSMonitor : MonoBehaviour {
    public GUISkin Skin;
    public float FPS;
    private float _currTime;
    private float _nextTime;
    private float _frameCount;

    private void Start() {
        _nextTime = Time.realtimeSinceStartup + 1;
    }

    private void OnGUI() {
#if !RELEASE
             if( Time.realtimeSinceStartup > _nextTime ) {
            FPS = Time.frameCount - _frameCount;
            _frameCount = Time.frameCount;
            _nextTime = Time.realtimeSinceStartup + 1;
        }

             GUILayout.Label(string.Format("<color=red>FPS : {0}</color> ", FPS), Skin.label);
#endif
   
    }
}