using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEditor.Recorder;
using UnityEditor.Recorder.Input;
using System;

public class RecordVideo : MonoBehaviour
{
    private string funword = DateTime.Now.ToString();
    private RecorderController TestRecorderController;
    public int VideoWidth;
    public int VideoHeight;
    public int Length;
    public InputField LengthField;
    public InputField WidthField;
    public InputField HeightField;

    private void StartRecorder()
    {
        Length = Convert.ToInt32(LengthField.text);
        VideoWidth = Convert.ToInt32(WidthField.text);
        VideoHeight = Convert.ToInt32(HeightField.text);

        var controllerSettings = ScriptableObject.CreateInstance<RecorderControllerSettings>();
        TestRecorderController = new RecorderController(controllerSettings);
        var videoRecorder = ScriptableObject.CreateInstance<MovieRecorderSettings>();
        videoRecorder.name = "My Video Recorder";
        videoRecorder.Enabled = true;
        videoRecorder.VideoBitRateMode = VideoBitrateMode.High;
        videoRecorder.ImageInputSettings = new GameViewInputSettings
        {
            OutputWidth = VideoWidth,
            OutputHeight = VideoHeight
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

    private void StopRecorder()
    {
        TestRecorderController.StopRecording();
    }

    private string RecordingName()
    {
        return string.Format("{0}/SaveExport/MP4Videos/Video_{1}",
            Application.dataPath,
            funword
        );
    }

}
