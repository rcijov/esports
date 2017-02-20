using System;
using XLabs.Platform.Device;

namespace esports.ViewModel
{
	public class MainViewModel : XLabs.Forms.Mvvm.ViewModel
	{
		private readonly IDevice _device;
		private string _message;
        private string _title;

		public MainViewModel(IDevice device)
		{
			_device = device;
			Message = String.Format("Main View {0} device", device.Manufacturer);
		}

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string Message
		{
			get { return _message; }
			set { SetProperty(ref _message, value); }
		}
	}
}
