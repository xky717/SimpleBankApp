using System;
using System.Collections.Generic;

namespace SimpleBankApp.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }       // 登录用户名（唯一）
        public string Email { get; set; }          // 邮箱
        public string PasswordHash { get; set; }   // 密码哈希
        public DateTime CreatedAt { get; set; }    // 注册时间

        // 导航属性：一个用户可以有多个账户
        public ICollection<BankAccount> Accounts { get; set; }
    }
}
