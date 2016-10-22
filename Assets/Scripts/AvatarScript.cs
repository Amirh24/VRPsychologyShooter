using UnityEngine;
using System.Collections;

public class AvatarScript : MonoBehaviour
{

    // Use this for initialization
    private Animator anim;
    int gotShotHash = Animator.StringToHash("isShot");
    AnimatorStateInfo stateInfo;

    void Start()
    {
        EventManager.pressedShoot += Animate;
        anim = GetComponent<Animator>();

    }

    public void Animate()
    {

            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Walking Again"))
                anim.SetBool(gotShotHash, true);

    }
}
