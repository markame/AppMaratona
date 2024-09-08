using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

namespace AppMaratona
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var cameraView = new CameraBarcodeReaderView
            {
                IsDetecting = true,
                Options = new BarcodeReaderOptions
                {
                    Formats = BarcodeFormat.QrCode,
                    AutoRotate = true,
                    //seta a opçao de identificar multiplos qrcodes
                    Multiple = true
                }
            };

            cameraView.BarcodesDetected += (s, e) =>
            {
                foreach (var barcode in e.Results)
                {
                    // Processar cada QR code detectado
                    // barcode. value é o responsavel por receber o JSON
                    Console.WriteLine($"QR Code detectado: {barcode.Value}");
                    var json = barcode.Value;
                   
                }
            };

            Content = cameraView;
        }
        // criem uma função para enviar para o banco.
        // criar uma classe e use a classe NewtonSoft para serializar o Json
    }
}
