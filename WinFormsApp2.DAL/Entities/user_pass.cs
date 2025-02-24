using System.ComponentModel.DataAnnotations;

namespace WinFormsApp2.DAL.Entities
{
	public class UserPass
	{
		[Key]
		public int ID { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
	}
}
