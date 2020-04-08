using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VrMobile
{
    public partial class SignatureExample : ContentPage
    {
        public SignatureExample()
        {
            InitializeComponent();
        }

        public async void ConvertSignToImage()
        {
            Stream img = await Sign.GetImagesStreamAsync(SignaturePad.Forms.SignatureImageFormat.Png);
            BinaryReader br = new BinaryReader();

            byte[] bytes = br.ReadBytes((Int32)img.Length);
            string bs64 = Convert.ToBase64String(bytes,0,bytes.Length);
            lbl.Text = bs64;
        }
    }
}
