using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BackGroundText : MonoBehaviour
{
    [SerializeField] private IntroNovel text;
    [SerializeField] private Text telopText;
    private float telopSpeed = 0.1f;
    private int dialogueListIndex = 0;
    [SerializeField] private MainStorycs mainStorycs;

    private void Start()
    {
        TextDisplay();
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0)) TextDisplay();
    }

    private void OnAllTextDisplayed()
    {
        mainStorycs.NaninovelInitial();
        Debug.Log("すべてのテキストが表示されました。");
    }


/// <summary>
/// テキスト表示されたときの処理
/// </summary>
    public void TextDisplay()
    {
        if (DOTween.IsTweening(telopText)) //IsTweening（）便利　dotweenが動いてるか判定してくれる
        {
            telopText.text = text.novel[dialogueListIndex - 1];
            telopText.DOKill();
        }
        else
        {
            if (dialogueListIndex >= text.novel.Count)
            {
                OnAllTextDisplayed();
                return;
            }
            string currentDialogue = text.novel[dialogueListIndex];
            telopText.text = "";
            telopText.DOText(text.novel[dialogueListIndex], text.novel[dialogueListIndex].Length * telopSpeed).SetEase(Ease.Linear);
            dialogueListIndex++;
        }
    }
}
