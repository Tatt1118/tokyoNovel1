using System.Collections;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Cysharp.Threading.Tasks;

public class TextManager : MonoBehaviour
{
    [SerializeField] private IntroNovel text;
    [SerializeField] private Text telopText;
    private float telopSpeed = 0.1f;
    private int dialogueListIndex = 0;
    private float nextTextTm = 1f;

    async void Start()
    {
        await StartTelop();
    }

    /// <summary>
    /// テキストリスト処理
    /// </summary>
    /// <returns></returns>
    private async UniTask StartTelop()
    {
        while (dialogueListIndex < text.novel.Count)
        {
            string currentDialogue = text.novel[dialogueListIndex];
            await DisplayText(currentDialogue);
            await UniTask.Delay((int)(nextTextTm * 1000));
            dialogueListIndex++;
        }
        // フェードアウトとフェードインが完了した後に実行する処理
        OnAllTextDisplayed();
    }

    /// <summary>
    /// テキストの文字表示処理
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    private async UniTask DisplayText(string text)
    {
        float displayTime = text.Length * telopSpeed;
        telopText.text = ""; // テキストのリセット
        await telopText.DOText(text, displayTime).SetEase(Ease.Linear).AsyncWaitForCompletion(); // 非同期で文字表示
    }

    /// <summary>
    ///テキストがすべて表示された処理
    /// </summary>
    private void OnAllTextDisplayed()
    {
        SceneManager.LoadScene("Intoro");
        Debug.Log("すべてのテキストが表示されました。");
    }
}