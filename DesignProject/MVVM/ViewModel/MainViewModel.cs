using DesignProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AppsViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public RelayCommand FeaturedViewCommand { get; set; }
       
        public HomeViewModel HomeVm { get; set; }
        public AppsViewModel AppsVm { get; set; }
        public DiscoveryViewModel DiscoveryVm { get; set; }
        public FeaturedViewModel FeaturedVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
        HomeVm = new HomeViewModel();
        AppsVm = new AppsViewModel();
        DiscoveryVm = new DiscoveryViewModel();
        FeaturedVm = new FeaturedViewModel();
        CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o => { 
                CurrentView = HomeVm;
            });
            AppsViewCommand = new RelayCommand(o => { 
                CurrentView = AppsVm;
            });
            DiscoveryViewCommand = new RelayCommand(o => { 
                CurrentView = DiscoveryVm;
            });
            FeaturedViewCommand = new RelayCommand(o => { 
                CurrentView = FeaturedVm;
            });

        }
    }
}
