﻿namespace Mango.Web.Utility;

public class SD
{
    //Base URL coupon API
    public static string CouponAPIBase { get; set; }
    public static string AuthAPIBase { get; set; }
    public enum ApiType
    {
        GET,
        POST,
        PUT,
        DELETE
    }
}
