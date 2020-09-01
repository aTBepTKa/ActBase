using ActBase.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ActBase.Services
{
    public interface IActService
    {
        void Dispose();
        Task<ObservableCollection<ActModel>> GetAllAsync();
        Task UpdateAsync(IEnumerable<ActModel> acts);
    }
}