using Microsoft.Extensions.Logging;
using System.ComponentModel;
using System.Web;
using System.Windows.Input;

namespace TitleViewTapDemo;

public partial class TitleView : ContentView, INotifyPropertyChanged
{

    public string Title
    {
        get { return TitleText.Text; }
        set { TitleText.Text = value; }
    }

    public TitleView()
    {
        InitializeComponent();
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.DisplayAlert("Tapped", "Button tapped", "Ok");
    }
}