using UMP;
using UnityEngine;
using UnityEngine.Assertions;

public class BugDemo : MonoBehaviour
{
    
/*
 * How to reproduce the bug:
 * 1. Run the app on an Android device.
 * 2. Press Play button.
 * 3. After the video has been started, press Quit.
 * 4. Run the app again.
 * 5. Press Play button.
 * 6. Crash.
 */
    
    public void PlayButtonHandler()
    {
        UniversalMediaPlayer player = FindObjectOfType<UniversalMediaPlayer>();
        Assert.IsNotNull(player);
        player.Path = "rtmp://vd2.wmspanel.com/video_demo/stream";
        player.Play();
    }

    public void QuitButtonHandler()
    {
        Application.Quit();
    }
}
