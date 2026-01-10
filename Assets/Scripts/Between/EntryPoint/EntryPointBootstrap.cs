using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class EntryPointBootstrap : MonoBehaviour
{
    [SerializeField]
    private TMP_Text text;
    private void Start()
    {
        StartCoroutine(AnimLoadScene());
    }
    private IEnumerator AnimLoadScene() 
    {
        text.DOColor(new Color(1, 1, 1, 1), 2f);
        yield return new WaitForSeconds(2f);
        yield return Load.Instance.LoadScene(1);
    }
}
