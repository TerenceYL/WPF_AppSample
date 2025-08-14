using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResizeProject.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {

        public MainViewModel() {
            AddNewRecordCommand = new RelayCommand(OnAddNewRecord);
        
        }

        private bool _isshowdetail;
        public bool IsShowDetail
        {
            get => _isshowdetail;
            set => SetProperty(ref _isshowdetail, value);

        }

        public IRelayCommand AddNewRecordCommand { get; }
        private void OnAddNewRecord()
        {
            IsShowDetail = true; 
        }
    }
}
