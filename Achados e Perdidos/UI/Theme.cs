namespace AchadosPerdidos.UI;
internal static class Theme
{
    public static readonly Color Navy=Color.FromArgb(8,57,109), Blue=Color.FromArgb(0,88,174), Orange=Color.FromArgb(255,111,0), Bg=Color.FromArgb(243,247,252), Ink=Color.FromArgb(29,46,70);
    public static Label Label(string text,int x,int y,int w=400,int h=24,int size=10,bool bold=false)=>new(){Text=text,Left=x,Top=y,Width=w,Height=h,ForeColor=Ink,Font=new Font("Segoe UI",size,bold?FontStyle.Bold:FontStyle.Regular)};
    public static Button Button(string text,int x,int y,int w=160,bool orange=false)=>new(){Text=text,Left=x,Top=y,Width=w,Height=39,FlatStyle=FlatStyle.Flat,BackColor=orange?Orange:Blue,ForeColor=Color.White,Font=new Font("Segoe UI",10,FontStyle.Bold),Cursor=Cursors.Hand};
    public static TextBox Input(int x,int y,int w=360)=>new(){Left=x,Top=y,Width=w,Font=new Font("Segoe UI",11)};
    public static ComboBox Combo(int x,int y,int w=360)=>new(){Left=x,Top=y,Width=w,DropDownStyle=ComboBoxStyle.DropDownList,Font=new Font("Segoe UI",11)};
}
