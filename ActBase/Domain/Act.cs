using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ActBase.Domain
{
    /// <summary>
    /// Акт освидетельствования скрытых работ.
    /// </summary>
    public class Act
    {
        public int ActId { get; set; }

        /// <summary>
        /// Наименование выполненных работ.
        /// </summary>
        public string WorkName { get; set; }

        /// <summary>
        /// Наименование последующих работ.
        /// </summary>
        public string NextWorkName { get; set; }

        /// <summary>
        /// Дата подписания.
        /// </summary>
        public DateTime SignDate { get; set; }

        /// <summary>
        /// Дата начала производства работ.
        /// </summary>
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// Дата окончания производства работ.
        /// </summary>
        public DateTime EndDate { get; set; }

        public virtual ICollection<Material> Materials { get; set; }
    }
}
