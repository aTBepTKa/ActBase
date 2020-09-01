using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ActBase.Model
{
    /// <summary>
    /// Примененныq материал.
    /// </summary>
    public class MaterialModel : INotifyPropertyChanged
    {
        private string name;

        public int MaterialId { get; set; }

        /// <summary>
        /// Наименование материала.
        /// </summary>
        public string Name
        {
            get => name; 
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }


        public virtual int ActId { get; set; }
        public virtual ActModel Act { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
