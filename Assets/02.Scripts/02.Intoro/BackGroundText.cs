using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Cysharp.Threading.Tasks;

public class BackGroundText : MonoBehaviour
{
    [SerializeField] private IntroNovel text;
    [SerializeField] private Text telopText;
    private float telopSpeed = 0.1f;
    private float nextTextTm = 2.3f;
    private int dialogueListIndex = 0;
    public Image backgroundImage;
    [SerializeField] public MainStorycs mainStorycs;

    async void Start()
    {
        await StartTelop();
    }

    private async UniTask StartTelop()
    {
        while (dialogueListIndex < text.novel.Count)
        {
            string currentDialogue = text.novel[dialogueListIndex];
            await DisplayText(currentDialogue);
            await UniTask.Delay((int)(nextTextTm * 1000));
            dialogueListIndex++;
        }

        // 背景画像のフェードアウトとテキストのフェードインを同時に実行する
        var sequence = DOTween.Sequence();
        var sequenceCompletionSource = new UniTaskCompletionSource();

        sequence.Append(backgroundImage.DOFade(0.0f, 3f));
        sequence.Join(telopText.DOFade(0f, 3f));
        sequence.OnComplete(() => sequenceCompletionSource.TrySetResult());

        // 両方のTweenが完了するまで待機する
        await sequenceCompletionSource.Task;

        // フェードアウトとフェードインが完了した後に実行する処理
        OnAllTextDisplayed();
    }

    private async UniTask DisplayText(string text)
    {
        float displayTime = text.Length * telopSpeed;
        telopText.text = ""; // テキストのリセット
        await telopText.DOText(text, displayTime).SetEase(Ease.Linear).AsyncWaitForCompletion(); // 非同期で文字表示
    }

    private void OnAllTextDisplayed()
    {
        mainStorycs.NaninovelInitial();
        Debug.Log("すべてのテキストが表示されました。");
    }
}
