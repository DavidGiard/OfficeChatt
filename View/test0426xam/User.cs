namespace test0426xam
{
	public class User
	{
		public int Id
		{
			get;
			set;
		}
		public string Name
		{
			get;
			set;
		}

		public string JobTitle
		{
			get;
			set;
		}

		public string PhoneNumber
		{
			get;
			set;
		}


		public User(int id, string name, string jobTitle, string phoneNumber)
		{
			Id = id;
			Name = name;
			JobTitle = jobTitle;
			PhoneNumber = phoneNumber;
		}
	}

}
