using BarcodeScanner.Mobile;
using System.Web;

namespace GeometriaMauiApp.Pages;


[QueryProperty(nameof(Parametro), "PARAMETRO")]
[QueryProperty(nameof(IsBrowser), "IS_BROWSER")]
[QueryProperty(nameof(Url), "URL")]
public partial class BarcodePage : ContentPage
{
    private TaskCompletionSource<string> _taskCompletionSource;

    public TaskCompletionSource<string> Parametro
    {
        get
        {
            return _taskCompletionSource;
        }
        set
        {
            _taskCompletionSource = value;
        }
    }

    string _url;
    public string Url
    {
        get
        {
            return _url;
        }
        set
        {
            _url = value;
        }
    }

    bool _isBroser;
    public bool IsBrowser
    {
        get
        {
            return _isBroser;
        }
        set
        {
            _isBroser = value;
        }
    }

    public BarcodePage()
    {
        InitializeComponent();

#if ANDROID || IOS

        BarcodeScanner.Mobile.Methods.SetSupportBarcodeFormat(BarcodeScanner.Mobile.BarcodeFormats.QRCode | BarcodeScanner.Mobile.BarcodeFormats.Code39);
        BarcodeScanner.Mobile.Methods.AskForRequiredPermission();
#endif
    }

    private void CameraView_OnDetected(object sender, BarcodeScanner.Mobile.OnDetectedEventArg e)
    {
        List<BarcodeResult> obj = e.BarcodeResults;

        string result = string.Empty;
        //for (int i = 0; i < obj.Count; i++)
        //{
        if (obj.Count > 0)
            result = $"{{\"Type\" : \"{obj[0].BarcodeType}\", \"Format\" : \"{obj[0].BarcodeFormat}\",  \"Value\" : \"{obj[0].DisplayValue}\"}}";
        //}

        _taskCompletionSource.TrySetResult(result);
        Dispatcher.Dispatch(async () =>
        {
            Camera.IsScanning = true;

            // AsemblyURL(Url, _isBroser, result);

            await Shell.Current.GoToAsync("//MainPage");
        });
    }

    async void AsemblyURL(string urlOriginal, bool AbrirEnVentanaNueva, string scannedValue)
    {
        string scannedValueEncoded = HttpUtility.UrlEncode(scannedValue);
        string url = urlOriginal.Replace("QRValue=QRValue", $"QRValue={scannedValueEncoded}");

        if (AbrirEnVentanaNueva)
        {
            await Launcher.OpenAsync(new Uri(url));
        }
        else
        {
        }
    }

    void SwitchCameraButton_Clicked(object sender, EventArgs e)
    {
        Camera.CameraFacing = Camera.CameraFacing == CameraFacing.Back ? CameraFacing.Front : CameraFacing.Back;
    }

    void TorchButton_Clicked(object sender, EventArgs e)
    {
        Camera.TorchOn = Camera.TorchOn == false;
    }

    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        base.OnNavigatedFrom(args);

        string? result = null;
        if (_taskCompletionSource != null && !_taskCompletionSource.Task.IsCompleted)
        {
            _taskCompletionSource.TrySetResult(result);
        }
    }
}