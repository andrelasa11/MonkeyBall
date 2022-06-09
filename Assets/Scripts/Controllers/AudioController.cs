using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController Instance;

    [Header("Effects")]
    public AudioClip kick;
    public AudioClip miss;
    public AudioClip goal;
    public AudioClip fire;

    [Header("Commentator")]
    public AudioClip commentatorGoal;

    //private
    private AudioSource audioSource;

    private void Awake()
    {
        Instance = this;
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    public void playKick() { playSound(kick); }
    public void playMiss() { playSound(miss); }
    public void playGoal() { playSound(goal); }
    public void playCommentatorGoal() { playSound(commentatorGoal); }
    public void playFire() { playSound(fire); }

    public void playSound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    private void OnDestroy()
    {
        Instance = null;
    }

}
