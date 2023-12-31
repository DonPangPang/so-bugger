using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorComponent;

namespace SoBugger.PwaClient.Consts;

public class SoBuggerConsts
{
    public const string AppName = "So? Bugger!";

    public class PageMap
    {
        public const string Home = "/";
        public const string Login = "/login";
        public const string Register = "/register";

        public const string Project = "/project";
        public const string Bug = "/bug";
        public const string Todo = "/todo";
        public const string Statistics = "/statistics";
    }

    public class MenuMap
    {
        public const string Home = "工作台";
        public const string Project = "项目";
        public const string Bug = "测试";
        public const string Todo = "Todo";
        public const string Statistics = "统计";
    }

    public class Account
    {
        public const string LoginSuccess = "Login success";

        public const string LoginFailed = "Login failed";

        public const string AccountNotEmpty = "Account not empty";

        public const string AccountNotValid = "Account not valid";

        public const int PasswordLenght = 8;

        public const string PasswordNotEmpty = "Password not empty";

        public const string PasswordNotMatch = "Password not match";

        public const string PasswordNotValid = "Password not valid";

        public const string PasswordLenghtNotValid = "Password lenght not valid";

        public const string VerifyPasswordNotEmpty = "Verify password not empty";

        public const string VerifyPasswordNotEqual = "Verify password not equal";

        public const string NameNotEmpty = "Name not empty";

        public const string EmailNotEmpty = "Email not empty";

        public const string EmailNotValid = "Email not valid";
    }
}
