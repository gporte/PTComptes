using PTComptes.Model.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace PTComptes.Modules.Entites.Services
{
	public class EntitesServices : IEntitesServices
	{
		private mainContext _context;

		/// <summary>
		/// Constructeur
		/// </summary>
		public EntitesServices() {
			this._context = new mainContext();
		}
		
		public ObservableCollection<Category> GetAllCategories() {
			return new ObservableCollection<Category>(
				this._context.Categories.OrderBy(x => x.Libelle)
			);
		}

		public Category GetCategory(long itemId) {
			return this._context.Categories.Find(itemId);
		}

		public void SaveCategory(Category itemToSave) {
			var originalItem = this.GetCategory(itemToSave.Id);

			if (originalItem != null) {
				this._context.Entry<Category>(originalItem).CurrentValues.SetValues(itemToSave);
			}
			else {
				this._context.Categories.Add(itemToSave);
			}
		}

		public void DeleteCategory(Category itemToDelete) {
			var originalItem = this.GetCategory(itemToDelete.Id);

			if (originalItem != null) {
				this._context.Categories.Remove(originalItem);
			}

			this._context.SaveChanges();
		}

		public ObservableCollection<Recipient> GetAllRecipients() {
			return new ObservableCollection<Recipient>(
				this._context.Recipients.OrderBy(x => x.Libelle)
			);
		}

		public Recipient GetRecipient(long itemId) {
			return this._context.Recipients.Find(itemId);
		}

		public void SaveRecipient(Recipient itemToSave) {
			var originalItem = this.GetRecipient(itemToSave.Id);

			if (originalItem != null) {
				this._context.Entry<Recipient>(originalItem).CurrentValues.SetValues(itemToSave);
			}
			else {
				this._context.Recipients.Add(itemToSave);
			}
		}

		public void DeleteRecipient(Recipient itemToDelete) {
			var originalItem = this.GetRecipient(itemToDelete.Id);

			if (originalItem != null) {
				this._context.Recipients.Remove(originalItem);
			}

			this._context.SaveChanges();
		}
	}
}
