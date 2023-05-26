using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace YoutubePlayer
{
    public class SimpleYoutubeVideo : MonoBehaviour
    {
        public InputField videoLink;
        async public void ViewYoutube()
        {
            string videoUrl = videoLink.text;
            Debug.Log("Loading video...");
            var videoPlayer = GetComponent<VideoPlayer>();
            await videoPlayer.PlayYoutubeVideoAsync(videoUrl);
        }
    }
}
