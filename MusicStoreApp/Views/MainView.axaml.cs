using Avalonia.Controls;
using Avalonia.ReactiveUI;
using MusicStoreApp.ViewModels;
using ReactiveUI;
using System.Threading.Tasks;

namespace MusicStoreApp.Views;

public partial class MainView : ReactiveWindow<MainViewModel>/*UserControl*/
{
    public MainView()
    {
        InitializeComponent();
        //this.WhenActivated(action => action(ViewModel!.ShowDialog.RegisterHandler(DoShowDialogAsync)));
    }
    //private async Task DoShowDialogAsync(IInteractionContext<MusicStoreViewModel,
    //                                           AlbumViewModel?> interaction)
    //{
    //    var dialog = new MusicStoreWindow();
    //    dialog.DataContext = interaction.Input;

    //    var result = await dialog.ShowDialog<AlbumViewModel?>(this);
    //    interaction.SetOutput(result);
    //}
}
