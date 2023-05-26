using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class YT_Play : MonoBehaviour
{
    // Start is called before the first frame update
    public VideoPlayer videoPlayer;
    public string youtubeUrl;

    public void YouTubePlaying()
    {
        videoPlayer.url = youtubeUrl;
        videoPlayer.Play();
    }
}
