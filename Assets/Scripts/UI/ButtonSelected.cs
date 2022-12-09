using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class ButtonSelected : MonoBehaviour
{
DefaultInputActions inputActions;
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject firstMainBtn;

    [SerializeField] GameObject settingsPanel;
    [SerializeField] GameObject firstSettingsBtn;

    public void OpenSettings()
    {
        mainPanel.SetActive(false);
        settingsPanel.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(firstSettingsBtn);
    }
    public void OpenMenu()
    {
        settingsPanel.SetActive(false);
        mainPanel.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(firstMainBtn);
    }


    private void Awake()
    {
        inputActions = new DefaultInputActions();
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void Update()
    {
        if (settingsPanel.activeInHierarchy && inputActions.UI.Cancel.triggered)
        {
            OpenMenu();
        }
    }


   
}
