using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class NativeAPI : MonoBehaviour
{
#if UNITY_IOS && !UNITY_EDITOR
            [DllImport("__Internal")]
            public static extern void sendMessageToMobileApp(string message);
#endif
}

[RequireComponent(typeof(Button))]
public class CallbackReactNative : MonoBehaviour
{
    Button callbackButton; 
    public static CallbackReactNative instance;

    // Start is called before the first frame update
    void Start()
    {
        callbackButton = GetComponent<Button>();
        callbackButton.onClick.AddListener(OnButtonClicked);
    }

    // Update is called once per frame
    void OnButtonClicked()
    {
        Debug.Log("Hello World");

        if (Application.platform == RuntimePlatform.Android)
        {
            using (AndroidJavaClass jc = new AndroidJavaClass("com.azesmwayreactnativeunity.ReactNativeUnityViewManager"))
            {
                jc.CallStatic("sendMessageToMobileApp", "Here is the Message");
            }
        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
#if UNITY_IOS && !UNITY_EDITOR
                        NativeAPI.sendMessageToMobileApp("Here is the Message");
#endif
        }
    }
}
