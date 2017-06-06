using System.Collections.Generic;

namespace FirstASPNetCore.Models
{
	public interface ICategoryRepository
	{
		IEnumerable<Category> Categories { get; }
	}
}