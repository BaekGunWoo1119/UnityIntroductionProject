using System;
using System.IO;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VoiceRecorder : MonoBehaviour
{
    private string funword = DateTime.Now.ToString();
    private AudioSource aud;
    private AudioClip recordedClip;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    public void StartRecording()
    {
        recordedClip = Microphone.Start(null, false, 3, 44100);
    }

    public void StopRecordingAndExport()
    {
        Microphone.End(null);
        if (recordedClip == null)
        {
            Debug.Log("No recorded audio");
            return;
        }

        string fileName = RecordingName();
        SavWav.Save(fileName, recordedClip);
        Debug.Log("Audio exported to: " + fileName);
    }

    private string RecordingName()
    {
        return string.Format("{0}/SaveExport/Audios/recordedAudio.wav",
            Application.dataPath,
            funword
        );
    }
}
