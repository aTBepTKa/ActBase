using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ActBase.Model
{
    /// <summary>
    /// Примененный материал.
    /// </summary>
    public class Material : INotifyPropertyChanged
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


        public virtual ICollection<ActMaterial> ActMaterials { get; private set; }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
