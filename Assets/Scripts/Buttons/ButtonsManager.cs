using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonsManager : MonoBehaviour
{
    [Header("Sprites")]
    public SpriteRenderer sr;
    public Sprite flagSprite;

    [Header("Box")]
    public BoxCollider2D box;

    [Header("Change State")]
    public string state = "black";
    public Animator animator;

    private Sprite _oldSprite;
    private bool _flagSpriteChange = false;

    private void Awake() {
        _oldSprite = sr.sprite;
    }

    private void OnMouseOver() {
        if (Input.GetMouseButtonDown(0) && !_flagSpriteChange) {
            sr.color = Color.white;
            //var targetHeight = new Vector3(1f, 1f, 1f);
            //var oldSize = sr.sprite.bounds.size.y;
            state = "flag";
            animator.SetTrigger("FadeOut");
            //var newSize = sr.sprite.bounds.size.y;
            //sr.transform.localScale = (oldSize / newSize) * targetHeight;

            box.size = new Vector3(5, 5);

            _flagSpriteChange = true;
        }
        if (Input.GetMouseButtonDown(1)) {
            Debug.Log("right");
            sr.color = Color.black;
            //var targetHeight = new Vector3(1f, 1f, 1f);
            //sr.sprite = _oldSprite;
            //sr.transform.localScale = targetHeight;
            state = "black";

            box.size = new Vector3(1, 1);

            _flagSpriteChange = false;
        }
    }

    public void ChangeSprite(Sprite oldSprite, Sprite newSprite) {
        var oldSize = oldSprite.bounds.size.y;
        var newSize = newSprite.bounds.size.y;
        sr.sprite = newSprite;

        var targetHeight = new Vector3(1f, 1f, 1f);
        sr.transform.localScale = (oldSize / newSize) * targetHeight;
    } 

}
