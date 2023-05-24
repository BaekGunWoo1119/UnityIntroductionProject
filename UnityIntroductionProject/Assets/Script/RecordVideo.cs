using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Recorder;
using UnityEditor.Recorder.Input;

public class RecordVideo : MonoBehaviour
{
    private int funword = 0;

    private RecorderController TestRecorderController;
    public int Length;

    private void Start()
    {

    }

    void Update()
    {

    }

    public void StartRecorder()
    {
        funword++;
        var controllerSettings = ScriptableObject.CreateInstance<RecorderControllerSettings>();
        TestRecorderController = new RecorderController(controllerSettings);
        var videoRecorder = ScriptableObject.CreateInstance<MovieRecorderSettings>();
        videoRecorder.name = "My Video Recorder";
        videoRecorder.Enabled = true;
        videoRecorder.VideoBitRateMode = VideoBitrateMode.High;
        videoRecorder.ImageInputSettings = new GameViewInputSettings
        {
            OutputWidth = 1920,
            OutputHeight = 1080
        };
        videoRecorder.AudioInputSettings.PreserveAudio = true;
        string fileName = RecordingName();
        videoRecorder.OutputFile = fileName;
        controllerSettings.AddRecorderSettings(videoRecorder);
        controllerSettings.SetRecordModeToFrameInterval(0, Length * 30); // 2s @ 30 FPS
        controllerSettings.FrameRate = 30;
        RecorderOptions.VerboseMode = false;
        TestRecorderController.PrepareRecording();
        TestRecorderController.StartRecording();
    }

    public void StopRecorder()
    {
        TestRecorderController.StopRecording();
    }

    public string RecordingName()
    {
        return string.Format("{0}/MP4Videos/video_{1}",
            Application.dataPath,
            funword
        );
    }
}
