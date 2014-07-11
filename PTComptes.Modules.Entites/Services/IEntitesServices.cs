using PTComptes.Model.Models;
using System.Collections.ObjectModel;

namespace PTComptes.Modules.Entites.Services
{
	public interface IEntitesServices
	{
		ObservableCollection<Category> GetAllCategories();
		Category GetCategory(long itemId);
		void SaveCategory(Category itemToSave);
		void DeleteCategory(Category itemToDelete);


		ObservableCollection<Recipient> GetAllRecipients();
		Recipient GetRecipient(long itemId);
		void SaveRecipient(Recipient itemToSave);
		void DeleteRecipient(Recipient itemToDelete);
	}
}
