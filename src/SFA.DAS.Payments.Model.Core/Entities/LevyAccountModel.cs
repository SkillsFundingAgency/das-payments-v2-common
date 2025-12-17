using System.ComponentModel.DataAnnotations.Schema;
using static SFA.DAS.Payments.Model.Core.Config.Consts;
namespace SFA.DAS.Payments.Model.Core.Entities
{
    public class LevyAccountModel
    {
        public long AccountId { get; set; }
        public string AccountName { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal Balance { get; set; }
        public bool IsLevyPayer { get; set; }
        [Column(TypeName = DbDecimalPlaceConfig)]
        public decimal TransferAllowance { get; set; }
    }
}
