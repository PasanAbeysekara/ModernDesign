using ModernDesign.Core;
using ModernDesign.MVVM.View;
using System;
using System.Linq.Expressions;

namespace ModernDesign.MVVM.ViewModel
{
	class MainViewModel:ObservableObject
	{
		public RelayCommand HomeViewCommand { get; set; }
		public RelayCommand DiscoveryViewCommand { get; set; }
		public DiscoveryViewModel DiscoveryVM { get; set; }
		public HomeViewModel HomeVM { get; set; }

		// temp setter for maintainting current state
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
			HomeVM = new HomeViewModel();
			DiscoveryVM = new DiscoveryViewModel();

			CurrentView = HomeVM;

			HomeViewCommand = new RelayCommand( o => {
				CurrentView = HomeVM;
			});

			DiscoveryViewCommand = new RelayCommand(o => {
				CurrentView = DiscoveryVM;
			});
		}
	}
}
