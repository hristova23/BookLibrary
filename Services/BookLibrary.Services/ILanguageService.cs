using BookLibrary.Services.Models.Language;
using System.Collections.Generic;

namespace BookLibrary.Services
{
    public interface ILanguageService
    {
        void Create(string name);
        IEnumerable<LanguageListingServiceModel> SearchByName(string name);
    }
}
