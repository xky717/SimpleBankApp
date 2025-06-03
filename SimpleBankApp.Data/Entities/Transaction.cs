using System;

namespace SimpleBankApp.Data.Entities
{
    public enum TransactionType
    {
        Deposit,
        Withdrawal
    }

    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }      // 交易时间
        public TransactionType Type { get; set; }    // 存款或取款
        public decimal Amount { get; set; }          // 金额
        public string Note { get; set; }             // 备注（可选）

        // 外键：属于哪个账户
        public int BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }
    }
}
