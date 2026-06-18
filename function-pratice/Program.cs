/*Function題目
1. 題目一 : 寫一個function 可以把一般對話框的文字轉成HTML。
2. 題目二 : 寫一個function，回傳輸入的值是否數字
3. 題目三 : 寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式
4. 題目四 : 寫一個function，回傳輸入的值是否符合手機格式
5. 題目五 : 寫一個function，回傳輸入的值是否符合身分證字號格式
6. 題目六 : 寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點
7. 題目七： 寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式
8. 題目八 : 寫一個function，輸入一個日期，把該日期轉成民國XX年XX月XX日 星期X 格式
9. 題目九 : 寫一個function，回傳輸入的年是否閏年
10 .題目十 : 寫一個function，輸入手機號碼，回傳今天運勢
(手機運勢算法：用你的手機號碼的最後四位數除以80，再減去整數部分（只留小數），再乘以80，就會得到一個數，這就是代表吉凶的數字，印出結果。)
https://kknews.cc/zh-tw/astrology/l26rzyb.html*/
using System;
using System.Text.RegularExpressions;

namespace FunctionPractice          // ← 命名空間(分類用)
{
    class Program                 // ← 類別(你的函式都放這)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("要跑到第幾題 Q1-10?");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    {
                        Console.WriteLine("請輸入文字會轉成html");
                        string word = Console.ReadLine() ?? "";
                        Console.WriteLine(Q1(word));
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("請輸入數字會告訴你是不是數字");
                        string number = Console.ReadLine() ?? "";
                        Console.WriteLine(Q2(number));
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("請輸入email會告訴你符不符合");
                        string email = Console.ReadLine() ?? "";
                        Console.WriteLine(Q3(email));
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("請輸入phone會告訴你符不符合");
                        string phone = Console.ReadLine() ?? "";
                        Console.WriteLine(Q4(phone));
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("請輸入身分證會告訴你符不符合");
                        string number = Console.ReadLine() ?? "";
                        Console.WriteLine(Q5(number));
                        break;
                    }
                case "6":
                    {
                        Console.WriteLine("請分別輸入文字和N會告訴你超不超過");
                        string word = Console.ReadLine() ?? "";
                        int N = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Q6(word, N));
                        break;
                    }
                case "7":
                    {
                        Console.WriteLine("請輸入日期");
                        Console.WriteLine("請輸入日期(格式 2024/06/18)");
                        string date = Console.ReadLine() ?? "";
                        Console.WriteLine(Q7(date));
                        break;
                    }
                case "8":
                    {
                        Console.WriteLine("請輸入日期");
                        Console.WriteLine("請輸入日期(格式 2024/06/18)");
                        string date = Console.ReadLine() ?? "";
                        Console.WriteLine(Q8(date));
                        break;
                    }
                case "9":
                    {
                        Console.WriteLine("請輸入年份判斷閏平年");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Q9(year));
                        break;
                    }
                    case "10":
                    {
                        Console.WriteLine("請輸入手機號碼，去判斷你的運氣");
                        string phone = Console.ReadLine()??"";
                        Console.WriteLine(Q10(phone));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("沒有這題喔");
                        break;
                    }
                //test
                case "testQ1":
                    {
                        TestQ1();
                        break;
                    }
            }
        }
        // 1. 題目一 : 寫一個function 可以把一般對話框的文字轉成HTML。
        static string Q1(string text)
        {
            string result = text.Replace(">", "&gt;");
            result = result.Replace("<", "&lt;");
            result = result.Replace("|", "&brvbar;");
            result = result.Replace(" ", "&nbsp;");
            result = result.Replace("\r\n", "<br>");
            return result;
        }
        // 2. 題目二 : 寫一個function，回傳輸入的值是否數字
        static string Q2(string text)
        {
            int result;
            if (int.TryParse(text, out result))
            {
                return result.ToString() + "是數字";
            }
            else
            {
                return "請輸入有效值";
            }

        }
        // 3. 題目三 : 寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式
        static string Q3(string email)
        {
            string pattern = @"^[^@\n]+@[^@\n]+\.[^@\n]+$";
            Regex regObj = new Regex(pattern);
            bool a = regObj.IsMatch(email);
            string result = "";
            if (a)
            {
                result = "符合的";
            }
            else
            {
                result = "不符合的";
            }
            return result;
        }
        // 4. 題目四 : 寫一個function，回傳輸入的值是否符合手機格式
        static string Q4(string number)
        {
            string pattern = @"^09\d{8}$";
            Regex regObj = new Regex(pattern);
            bool a = regObj.IsMatch(number);
            string result = "";
            if (a)
            {
                result = "符合的";
            }
            else
            {
                result = "不符合的";
            }
            return result;
        }
        // 5. 題目五 : 寫一個function，回傳輸入的值是否符合身分證字號格式
        static string Q5(string number)
        {
            string pattern = @"^[A-Z]\d{9}$";
            Regex regObj = new Regex(pattern);
            bool a = regObj.IsMatch(number);
            string result = "";
            if (a)
            {
                result = "符合的";
            }
            else
            {
                result = "不符合的";
            }
            return result;
        }
        // 6. 題目六 : 寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點
        static string Q6(string word, int N)
        {
            string result = "";
            if (word.Length <= N)
            {
                result = word;
            }
            else
            {
                string dot = new string('.', word.Length - N);
                result = word.Substring(0, N) + dot;
            }
            return result;
        }
        // 7. 題目七： 寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式
        static string Q7(string date)
        {
            if (!Regex.IsMatch(date, @"^\d+/\d+/\d"))
            {
                return "格式錯誤";
            }
            string[] p = date.Split('/');
            int year = int.Parse(p[0]);
            int month = int.Parse(p[1]);
            int day = int.Parse(p[2]);
            if (year < 0) return "年份錯誤";
            if (month <= 0 || month > 12) return "月份錯誤";
            if (day <= 0 || month > 31) return "天數錯誤";
            return (year - 1911) + "." + p[1] + "." + p[2];
        }
        // 8. 題目八 : 寫一個function，輸入一個日期，把該日期轉成民國XX年XX月XX日 星期X 格式
        static string Q8(string input)
        {
            if (!Regex.IsMatch(input, @"^\d+/\d+/\d"))
            {
                return "格式錯誤";
            }
            string[] p = input.Split('/');
            int year = int.Parse(p[0]);
            int month = int.Parse(p[1]);
            int day = int.Parse(p[2]);

            if (year < 0) return "年份錯誤";
            if (month <= 0 || month > 12) return "月份錯誤";
            if (day <= 0 || day > 31) return "天數錯誤";
            DateTime date = new DateTime(year, month, day);
            int dayNumber = (int)date.DayOfWeek;
            string dayofweek = "";
            switch (dayNumber)
            {
                case 0: dayofweek = "星期日"; break;
                case 1: dayofweek = "星期一"; break;
                case 2: dayofweek = "星期二"; break;
                case 3: dayofweek = "星期三"; break;
                case 4: dayofweek = "星期四"; break;
                case 5: dayofweek = "星期五"; break;
                case 6: dayofweek = "星期六"; break;
            }
            return "民國" + (year - 1911) + "年" + p[1] + "月" + p[2] + "日" + " " + "星期" + dayofweek;
        }
        // 9. 題目九 : 寫一個function，回傳輸入的年是否閏年
        static string Q9(int year)
        {
            string result = "";
            if (year % 100 == 0 && year % 400 == 0)
            {
                result = "閏年";
            }
            else if (year % 100 == 0 && year % 400 != 0)
            {
                result = "平年";
            }
            else if (year % 4 == 0)
            {
                result = "閏年";
            }
            else
            {
                result = "平年";
            }
            return result;
        }
        // 10 .題目十 : 寫一個function，輸入手機號碼，回傳今天運勢
        //test
        static string[] table = {
    "具有非凡特質，以名人猛人居多",   // 0（猛0）
    "大展鴻圖．可獲成功 吉",        // 1
    "一盛一衰．勞而無功 凶",        // 2
    "蒸蒸日上．百事順遂 吉",        // 3
    "坎坷前途．苦難折磨 凶",        // 4
    "生意欣榮．名利雙收 吉",        // 5
    "天降幸運．可成大功 吉",        // 6
    "和氣致祥．必獲成功 吉",        // 7
    "貫徹志望．成功可期 吉",        // 8
    "獨營無力．財利無望 凶",        // 9
    "空費心力．徒勞無功 凶",        // 10
    "穩健著實．必得人望 吉",        // 11
    "薄弱無力．謀事難成 凶",        // 12
    "天賦吉運．能得人望 吉",        // 13
    "是成是敗．惟靠堅毅 凶",        // 14
    "大事成就．一定興隆 吉",        // 15
    "成就大業．名利雙收 吉",        // 16
    "有貴人助．可得成功 吉",        // 17
    "順利昌隆．百事亨通 吉",        // 18
    "內外不合．障礙重重 凶",        // 19
    "歷盡艱難．焦心憂勞 凶",        // 20
    "專心經營．善用智慧 吉",        // 21
    "懷才不遇．事不如意 凶",        // 22
    "名顯四方．終成大業 吉",        // 23
    "須靠自力．能奏大功 吉",        // 24
    "天時地利．再得人格 吉",        // 25
    "波瀾起伏．凌駕萬難 凶",        // 26
    "一盛一衰．可守成功 凶帶吉",    // 27
    "遇衰轉吉．遇厄轉好 吉",        // 28
    "青雲直上．才略奏功 吉",        // 29
    "吉凶參半．得失相伴 凶",        // 30
    "名利雙收．大業成就 吉",        // 31
    "池中之龍．成功可望 吉",        // 32
    "智慧慎始．必可昌隆 吉",        // 33
    "災難不絕．難望成功 凶",        // 34
    "中吉之數．進退保守 吉",        // 35
    "波瀾重疊．常陷窮困 凶",        // 36
    "逢凶化吉．風調雨順 吉",        // 37
    "名雖可得．利則難獲 凶帶吉",    // 38
    "光明坦途．指日可待 吉",        // 39
    "一盛一衰．浮沉不定 吉帶凶",    // 40
    "天賦吉運．前途無限 吉",        // 41
    "事業不專．十九不成 吉帶凶",    // 42
    "忍耐自重．轉凶為吉 吉帶凶",    // 43
    "事難遂願．貪功好進 凶",        // 44
    "綠葉發枝．一舉成名 吉",        // 45
    "坎坷不平．艱難重重 凶",        // 46
    "有貴人助．可成大業 吉",        // 47
    "名利俱全．繁榮富貴 吉",        // 48
    "遇吉則吉．遇凶則凶 凶",        // 49
    "吉凶互見．一成一敗 吉帶凶",    // 50
    "一盛一衰．浮沉不常 吉帶凶",    // 51
    "雨過天青．即獲成功 吉",        // 52
    "盛衰參半．先吉後凶 吉帶凶",    // 53
    "雖傾全力．難望成功 凶",        // 54
    "外觀隆昌．內隱禍患 吉帶凶",    // 55
    "事與願違．終難成功 凶",        // 56
    "努力經營．時來運轉 吉",        // 57
    "浮沉多端．始凶終吉 凶帶吉",    // 58
    "遇事猶疑．難望成事 凶",        // 59
    "心迷意亂．難定方針 凶",        // 60
    "雲遮半月．百隱風波 吉帶凶",    // 61
    "煩悶懊惱．事事難展 凶",        // 62
    "萬物化育．繁榮之象 吉",        // 63
    "十九不成．徒勞無功 凶",        // 64
    "吉運自來．能享盛名 吉",        // 65
    "內外不和．信用缺乏 凶",        // 66
    "事事如意．富貴自來 吉",        // 67
    "不失先機．可望成功 吉",        // 68
    "動搖不安．常陷逆境 凶",        // 69
    "慘澹經營．難免貧困 凶",        // 70
    "吉凶參半．惟賴勇氣 吉帶凶",    // 71
    "得而復失．難以安順 凶",        // 72
    "安樂自來．自然吉祥 吉",        // 73
    "如無智謀．難望成功 凶",        // 74
    "吉中帶凶．進不如守 吉帶凶",    // 75
    "此數大凶．破產之象 凶",        // 76
    "先苦後甘．不致失敗 吉帶凶",    // 77
    "有得有失．華而不實 吉帶凶",    // 78
    "前途無光．希望不大 凶",        // 79
    "得而復失．枉費心機 吉帶凶",    // 80
    "最極之數．能得成功 吉",        // 81
};
        static string Q10(string phone)
        {
            int last4 = int.Parse(phone.Substring(phone.Length - 4));
            int fate = last4 % 80; // 除80-整數x80 等於對80做取於數
            return table[fate];
        }
        static void TestQ1()
        {
            string[,] cases = {
          { "a < b",                  "a&nbsp;&lt;&nbsp;b" },
          { "x > y",                  "x&nbsp;&gt;&nbsp;y" },
          { "a | b",                  "a&nbsp;&brvbar;&nbsp;b" },
          { "<div>hi</div>",          "&lt;div&gt;hi&lt;/div&gt;" },
          { "5 < 10 | ok",            "5&nbsp;&lt;&nbsp;10&nbsp;&brvbar;&nbsp;ok" },
          { "a b c",                  "a&nbsp;b&nbsp;c" },
          { "a\r\nb",                 "a<br>b" },
          { "<p>\r\n</p>",            "&lt;p&gt;<br>&lt;/p&gt;" },
          { "價格 < 100\r\n備註 | 急件", "價格&nbsp;&lt;&nbsp;100<br>備註&nbsp;&brvbar;&nbsp;急件" },
          { "",                       "" },
      };

            for (int i = 0; i < cases.GetLength(0); i++)
            {
                string actual = Q1(cases[i, 0]);
                string mark = actual == cases[i, 1] ? "✅" : "❌";
                string showIn = cases[i, 0].Replace("\r\n", "\\r\\n");
                Console.WriteLine($"{mark} [{showIn}] → [{actual}]  預期[{cases[i, 1]}]");
            }
        }
    }
}
