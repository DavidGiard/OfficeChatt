using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace test0426xam
{
	public class UsersViewModel : INotifyPropertyChanged
	{
		ObservableCollection<User> _usersCollection = new ObservableCollection<User>();

		public UsersViewModel()
		{
			var u1 = new User(1, "David Giard", "Senior Technical Evangelist", "999-999-9999");
			_usersCollection.Add(u1);
			var u2 = new User(2, "Jennifer Marsman", "Mother of Dragons", "111-222-3333");
			_usersCollection.Add(u2);
			var u3 = new User(3, "David Washington", "Big Cheese", "444-555-6666");
			_usersCollection.Add(u3);
			var u4 = new User(4, "John Alioto", "Head Honcho", "777-888-9999");
			_usersCollection.Add(u4);


		}

		public ObservableCollection<User> UsersCollection
		{
			get
			{
				return _usersCollection;
			}
			set
			{
				_usersCollection = value;
				PropertyChanged(this, new PropertyChangedEventArgs("Users")); 

			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

	}
}
