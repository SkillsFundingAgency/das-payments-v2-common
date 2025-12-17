using System.ComponentModel.DataAnnotations.Schema;
using static SFA.DAS.Payments.Model.Core.Config.Consts;

namespace SFA.DAS.Payments.Model.Core.Entities
{
    public class LevyAccountAuditModel
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public short AcademicYear { get; set; }
        public byte CollectionPeriod { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal SourceLevyAccountBalance { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal AdjustedLevyAccountBalance { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal SourceTransferAllowance { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal AdjustedTransferAllowance { get; set; } 
        public bool IsLevyPayer { get; set; }
    }
}
