using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    public Animator animator;
    string nextSceneName = "Puzzle";

    private bool isAnimPlaying = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false;
    }
    public void PlayAnimationAndSwitchScene()
    {
        if (!isAnimPlaying)
        {
            animator.enabled = true;
            isAnimPlaying = true;
            Invoke("SwitchScene", 2.1f);
        }
    }
    void SwitchScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }

}
