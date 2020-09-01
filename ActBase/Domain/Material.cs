using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ActBase.Domain
{
    /// <summary>
    /// Примененныq материал.
    /// </summary>
    public class Material
    {
        public int MaterialId { get; set; }

        /// <summary>
        /// Наименование материала.
        /// </summary>
        public string Name { get; set; }


        public virtual int ActId { get; set; }
        public virtual Act Act { get; set; }
    }
}
