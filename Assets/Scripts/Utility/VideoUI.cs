using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

[RequireComponent(typeof(RawImage), typeof(VideoPlayer))]
public class VideoUI : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    private RawImage _rawImage;
    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        _rawImage = GetComponent<RawImage>();
    }

    private void Update()
    {
        if (videoPlayer.isPrepared)
        {
            _rawImage.texture = videoPlayer.texture;
        } 
    }
}
