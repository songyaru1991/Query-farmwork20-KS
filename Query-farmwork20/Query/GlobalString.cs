using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Query
{
    class GlobalString
    {
        public static string UserID = ""; //定义工號
        public static string ChineseName = ""; //定义名字
        public static string Password = "";//密碼
        public static string CostID = "";
        public static string Query_CostID = "";
        //public static string BU = "";
        public static List<string> ListCostID = new List<string>();
        public static List<string> ListQuery_CostID = new List<string>();
        public static List<string> ListBU = new List<string>();

        public static string _UserID
        {
            get { return UserID; }
            set { UserID = value; }

        }

        public static string _ChineseName
        {
            get { return ChineseName; }
            set { ChineseName = value; }

        }

        public static string _Password
        {
            get { return Password; }
            set { Password = value; }

        }
        public static string _CostID
        {
            get { return CostID; }
            set { CostID = value; }

        }
        public static string _Query_CostID
        {
            get { return Query_CostID; }
            set { Query_CostID = value; }

        }
        public static List<string> _ListBU
        {
            get { return ListBU; }
            set { ListBU = value; }

        }
        public static List<string> _ListCostID
        {
            get { return ListCostID; }
            set { ListCostID = value; }

        }
        public static List<string> _ListQuery_CostID
        {
            get { return ListQuery_CostID; }
            set { ListQuery_CostID = value; }

        }
    }
}
