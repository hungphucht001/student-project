using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chicken.App_Start
{
    public class Decentralization
    {
        public static int quyen(String cv)
        {
            switch (cv)
            {
                case "Giám đốc":
                    {
                        return 1;
                    }
                case "Quản lý":
                    {
                        return 2;
                    }
                case "Nhân viên tư vấn & duyệt đơn hàng":
                    {
                        return 3;
                    }
                case "Đầu bếp":
                    {
                        return 4;
                    }
            }
            return 101020;
        }
    }
}