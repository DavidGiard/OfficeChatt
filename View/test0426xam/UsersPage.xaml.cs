using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace test0426xam
{
	public partial class UsersPage : ContentPage
	{
		public UsersPage()
		{
			var usersVM = new UsersViewModel();

			BindingContext = usersVM;
			InitializeComponent();
		}
	}
}

