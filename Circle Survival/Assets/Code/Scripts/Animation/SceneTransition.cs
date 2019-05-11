using UnityEngine;

//Używany przez Transition
//Ustawia odpowiedni trigger Animatora
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
