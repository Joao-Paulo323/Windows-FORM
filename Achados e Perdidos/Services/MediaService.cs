using System.Drawing.Imaging;
using QRCoder;
using AchadosPerdidos.Data;
namespace AchadosPerdidos.Services;
public static class MediaService
{
    public static string SavePhoto(string source)
    {
        using var original=Image.FromFile(source);
        double scale=Math.Min(1,1000.0/Math.Max(original.Width,original.Height));
        using var bmp=new Bitmap(Math.Max(1,(int)(original.Width*scale)),Math.Max(1,(int)(original.Height*scale)));
        using(var g=Graphics.FromImage(bmp)){g.Clear(Color.White);g.InterpolationMode=System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;g.DrawImage(original,0,0,bmp.Width,bmp.Height);}
        var name=Guid.NewGuid().ToString("N")+".jpg";
        var enc=ImageCodecInfo.GetImageEncoders().First(x=>x.MimeType=="image/jpeg");
        using var p=new EncoderParameters(1);p.Param[0]=new EncoderParameter(System.Drawing.Imaging.Encoder.Quality,75L);
        bmp.Save(Path.Combine(Database.Fotos,name),enc,p);return name;
    }
    public static Bitmap Qr(string code)
    {
        using var generator=new QRCodeGenerator();using var data=generator.CreateQrCode(code,QRCodeGenerator.ECCLevel.Q);using var qr=new QRCode(data);return qr.GetGraphic(7);
    }
}
