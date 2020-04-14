﻿using UnityEngine;
using System.Collections;
using DG.Tweening;
using System.Threading.Tasks;

public class TitleView : MonoBehaviour {

    public float transitionDuration = 17f;
    public GameObject mainCamera;
    public GameObject panorama;
    public SpriteRenderer starSprite;
    public FadeImageEffect fade;

    public CanvasGroup title;
    public CanvasGroup credit1;
    public CanvasGroup credit2;
    public CanvasGroup credit3;
    public CanvasGroup credit4;
    public CanvasGroup credit5;

    public void OnEnable() {
        DoMenuAsync();
    }

    public async void DoMenuAsync() {
        await Global.Instance().Input.ConfirmRoutine();
        await PanRoutine();
    }

    public IEnumerator PanRoutine() {
        var cameraTween = mainCamera.transform.DOLocalMoveY(-4.5f, transitionDuration);
        var panoramaTween = panorama.transform.DOLocalMoveY(0.0f, transitionDuration);
        var starTween = starSprite.DOFade(0.0f, transitionDuration);
        var titleTween = title.DOFade(0.0f, transitionDuration);
        cameraTween.SetEase(Ease.Linear);
        panoramaTween.SetEase(Ease.Linear);
        starTween.SetEase(Ease.Linear);

        cameraTween.Play();
        panoramaTween.Play();
        starTween.Play();
        title.DOFade(0.0f, 1.0f).Play();
        StartCoroutine(CoUtils.RunAfterDelay(3, () => { StartCoroutine(CrossfadeObj(credit1)); }));
        StartCoroutine(CoUtils.RunAfterDelay(8, () => { StartCoroutine(CrossfadeObj(credit2)); }));
        StartCoroutine(CoUtils.RunAfterDelay(13, () => { StartCoroutine(CrossfadeObj(credit3)); }));
        StartCoroutine(CoUtils.RunAfterDelay(18, () => { StartCoroutine(CrossfadeObj(credit4)); }));

        
        yield return CoUtils.Wait(transitionDuration - 11f);

        yield return CrossfadeObj(credit5);

        yield return CoUtils.Wait(1.0f);
        
        Global.Instance().StartCoroutine(Global.Instance().Maps.NewGameRoutine(fade));
    }

    public IEnumerator CrossfadeObj(CanvasGroup group) {
        group.gameObject.SetActive(true);
        float time = 1.0f;
        yield return CoUtils.RunTween(group.DOFade(1.0f, time));
        yield return CoUtils.Wait(time);
        yield return CoUtils.RunTween(group.DOFade(0.0f, time));
    }
}
