using UnityEngine;
using UnityEngine.UI;

public class PanelDiscription : MonoBehaviour
{
    InfoCharacter _info;

    public InfoCharacter Info { get => _info; }


    private void OnDestroy()
    {
        EventBus.OnInfoCharacter -= SetBackground;
    }

    public void Spawn(InfoCharacter character)
    {
        _info = character;

        transform.GetChild(0).GetComponent<Image>().sprite = _info.Character;
        transform.GetChild(1).GetComponent<Localize>().LocalizationKey = _info.Discription;
        transform.GetChild(2).GetComponent<Image>().sprite = _info.BaseWeapon;

        GetComponent<Button>().onClick.AddListener(() =>
        {
            EventBus.OnInfoCharacter?.Invoke(this);
        });

        GetComponent<RectTransform>().localScale = Vector3.one;
        GetComponent<RectTransform>().position = new Vector3(transform.position.x, transform.position.y, 0);
        EventBus.OnInfoCharacter += SetBackground;
    }

    private void SetBackground(PanelDiscription panel)
    {
        if (panel == this)
            transform.GetComponent<Image>().color = new Color(0.3179581f, 1, 0.04150939f, 0.3921569f);
        else
            transform.GetComponent<Image>().color = new Color(0.5943396f, 0.01345673f, 0.01345673f, 0.3921569f);
    }
}

