using ActBase.Domain;
using ActBase.Model;
using ActBase.Storage;
using Mapster;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace ActBase.Services
{
    /// <summary>
    /// Сервис работы с актами ОСР.    
    /// </summary>
    public class ActService : IActService
    {
        private readonly UnitOfWork unitOfWork = new UnitOfWork();

        /// <summary>
        /// Получить коллекцию актов.
        /// </summary>
        /// <returns></returns>
        public async Task<ObservableCollection<ActModel>> GetAllAsync()
        {
            var acts = await unitOfWork.ActRepository.GetAllAsync();
            var actsModel = acts.Adapt<IEnumerable<ActModel>>();
            var actsModelObservable = new ObservableCollection<ActModel>(actsModel);
            return actsModelObservable;
        }

        public async Task UpdateAsync(IEnumerable<ActModel> acts)
        {
            var actsDomain = acts.Adapt<IEnumerable<Act>>();
            unitOfWork.ActRepository.Update(actsDomain);
            await unitOfWork.ActRepository.SaveChangesAsync();
        }

        public void Dispose()
        {
            unitOfWork.Dispose();
        }
    }
}
