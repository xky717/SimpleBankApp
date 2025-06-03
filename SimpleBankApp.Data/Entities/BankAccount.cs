using System;
using System.Collections.Generic;

namespace SimpleBankApp.Data.Entities
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }   // 账号
        public decimal Balance { get; set; }        // 当前余额
        public DateTime CreatedAt { get; set; }     // 创建时间

        // 外键：所属用户
        public int UserId { get; set; }
        public User User { get; set; }

        // 导航属性：一个账户可以有多个交易记录
        public ICollection<Transaction> Transactions { get; set; }
    }
}
