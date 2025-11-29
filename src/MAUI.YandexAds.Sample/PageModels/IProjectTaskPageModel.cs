using CommunityToolkit.Mvvm.Input;
using MAUI.YandexAds.Sample.Models;

namespace MAUI.YandexAds.Sample.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}