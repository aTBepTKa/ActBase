using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ActBase.Model
{
    /// <summary>
    /// Акт освидетельствования скрытых работ.
    /// </summary>
    public class ActModel : INotifyPropertyChanged
    {
        private string workName;
        private string nextWorkName;
        private DateTime signDate;
        private DateTime beginDate;
        private DateTime endDate;

        public int ActId { get; set; }

        /// <summary>
        /// Наименование выполненных работ.
        /// </summary>
        public string WorkName
        {
            get => workName;
            set
            {
                workName = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Наименование последующих работ.
        /// </summary>
        public string NextWorkName
        {
            get => nextWorkName;
            set
            {
                nextWorkName = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Дата подписания.
        /// </summary>
        public DateTime SignDate
        {
            get => signDate;
            set
            {
                signDate = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Дата начала производства работ.
        /// </summary>
        public DateTime BeginDate
        {
            get => beginDate;
            set
            {
                beginDate = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Дата окончания производства работ.
        /// </summary>
        public DateTime EndDate
        {
            get => endDate;
            set
            {
                endDate = value;
                OnPropertyChanged();
            }
        }

        public virtual ICollection<MaterialModel> Materials { get; private set; } = new ObservableCollection<MaterialModel>();


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
