using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    Animator transitionAnimator;

    private void Awake()
    {
        transitionAnimator = GetComponentInChildren<Animator>();
    }

    public void BeginTransition()
    {
        transitionAnimator.SetTrigger("FadeOut");
    }
}
