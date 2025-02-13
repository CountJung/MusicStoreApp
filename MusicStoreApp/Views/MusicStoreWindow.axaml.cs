using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using MusicStoreApp.ViewModels;
using ReactiveUI;
using System;

namespace MusicStoreApp.Views;

public partial class MusicStoreWindow : ReactiveWindow<MusicStoreViewModel> /*Window*/
{
    public MusicStoreWindow()
    {
        InitializeComponent();
        if (Design.IsDesignMode) return;

        this.WhenActivated(action => action(ViewModel!.BuyMusicCommand.Subscribe(Close)));
    }
}