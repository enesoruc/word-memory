using System;
using System.Collections.Generic;

namespace WordMemory.Model
{

    public partial class WordPool
    {

        public WordPool()
        {

        }

        public Guid WordPoolID { get; set; }
        public Guid UserID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return this.Name;
        }


    }
}
