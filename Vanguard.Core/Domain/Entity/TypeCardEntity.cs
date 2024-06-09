using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Core.Domain.Entity
{

    public class TypeCardEntity<TKey> : CardEntity<TKey> where TKey : struct
    {
        [StringLength(maximumLength: 100)]
        public string Title { get; set; }
        [AllowNull]
        public string Abbreviation { get; set; } = null;
        [AllowNull]
        public string Code { get; set; }
        [AllowNull]
        public string Description { get; set; }

    }
}
