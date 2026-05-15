using Microsoft.AspNetCore.Mvc;

namespace WebApp_Exercise.Controllers
{

    /// <summary>
    /// 演習-04 クエリパラメータを取得するコントローラを実装する
    /// </summary>
    [Route("Op02")]
    public class Op02Controller : Controller
    {
        /// <summary>
        /// クエリパラメータを取得して計算結果を返す
        /// </summary>
        /// <param name="opt">計算種別（1:加算、2:減算、3:乗算、4:除算、5:剰余）</param>
        /// <param name="value1">値1</param>
        /// <param name="value2">値2</param>
        /// <returns></returns>
    [HttpGet("Calc/{value1}/{value2}/{opt}")]


public IActionResult Calc( int value1, int value2, int opt)
    {
        string result;


        switch (opt)
        {
            case 1:
                result = $"{value1 + value2}";
                break;

            case 2:
                result = $"{value1 - value2}";
                break;

            case 3:
                result = $"{value1 * value2}";
                break;

            case 4:
                result = $"{value1 / value2}";
                break;

            case 5:
                result = $"{value1 % value2}";
                break;

            default:
                result = "不明な計算種別です。";
                break;
        }

        return Content(value1.ToString() + "  " + opt.ToString() + " " + value2.ToString() + " = " + result);
    }
}
}




