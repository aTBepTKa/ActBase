using System;
using System.Collections.Generic;
using System.Text;

namespace ActBase.Model
{
    /// <summary>
    /// Назначение материала акту
    /// </summary>
    public class ActMaterial
    {
        public int ActMaterialId { get; set; }


        public virtual Act Act { get; set; }
        public virtual int ActId { get; set; }

        public virtual Material Material { get; set; }
        public virtual int MaterialId { get; set; }
    }
}
