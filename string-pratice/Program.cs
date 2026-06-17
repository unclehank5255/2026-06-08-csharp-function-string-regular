// 1.輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。
// 2.請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。
// 3.輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e。
// 4.輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。
// 5.輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字。Length  Substring()
// 6.輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌。Replace()
// 7.輸入一串字，顯示輸入幾個字。Length
// 8.(補充1)連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。
// 9.(補充2)用字母大小寫來模擬波浪舞的動作後輸出，比如輸入FiFa，輸出FifafIfafiFafifA
// 10.(補充3)輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分。
// 11.(補充4)輸入的字，轉成HTML，例如輸入Justin,Amy,David 輸出<ul>	<li>Justin<li>		<li>Amy<li>	<li>David<li></ul>
// 12.(補充5)輸入5處數字，用空白隔開，輸出結果。例如：輸入‘11 19 12 25 1 7 12，輸出總和是87
// 13.(補充6)輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("要跑到第幾題Q1-13?");
        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                {
                    Console.WriteLine("請輸入名字");
                    string name = Console.ReadLine()!;
                    Console.WriteLine(Q1(name));
                    break;
                }
            case "2":
                {
                    Console.WriteLine("請輸入任何一個字");
                    string word = Console.ReadLine()!;
                    Console.WriteLine(Q2(word));
                    break;
                }
            case "3":
                {
                    Console.WriteLine("請輸入一段字");
                    string word = Console.ReadLine()!;
                    Console.WriteLine(Q3(word));
                    break;
                }
            case "4":
                {
                    Console.WriteLine("輸入一個檔名輸出副檔名");
                    string word = Console.ReadLine() ?? "";
                    Console.WriteLine(Q4(word));
                    break;
                }
            case "5":
                {
                    Console.WriteLine("請輸入一個大於五的字的單字");
                    string word = Console.ReadLine() ?? "";
                    Console.WriteLine(Q5(word));
                    break;
                }
            case "6":
                {
                    Console.WriteLine("請輸入一段字，我會變成小名");
                    string word = Console.ReadLine()!;
                    Console.WriteLine(Q6(word));
                    break;
                }
            case "7":
                {
                    Console.WriteLine("輸入一串字，顯示輸入幾個字");
                    string word = Console.ReadLine()!;
                    Console.WriteLine(Q7(word));
                    break;
                }
            case "8":
                {
                    Q8();
                    break;
                }
            case "9":
                {
                    Console.WriteLine("輸入一個單字");
                    string word = Console.ReadLine() ?? "";
                    Console.WriteLine(Q9(word));
                    break;
                }
            case "10":
                {
                    Console.WriteLine("輸入時間");
                    string time = Console.ReadLine() ?? "";
                    Console.WriteLine(Q10(time));
                    break;
                }
            case "11":
                {
                    Console.WriteLine("輸入輸入名字,名字,...");
                    string name = Console.ReadLine() ?? "";
                    Console.WriteLine(Q11(name));
                    break;
                }
            case "12":
                {
                    Console.WriteLine("輸入五處空白數字，用空白鍵格開");
                    string number = Console.ReadLine() ?? "";
                    Console.WriteLine(Q12(number));
                    break;
                }
            case "13":
                {
                    Console.WriteLine("輸入一串文字，倒著輸出");
                    string word = Console.ReadLine() ?? "";
                    Console.WriteLine(Q13(word));
                    break;
                }

            default: Console.WriteLine("沒有這題"); break;

        }
    }
    // 1.輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。
    static string Q1(string text)
    {
        return "Hi~" + text;
    }
    // 2.請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。
    static string Q2(string text)
    {
        string target = "人人為我,我為人人、饒人不癡漢,癡漢不饒人";
        bool found = false;
        for (int i = 0, a = target.Length; i < a; i++)
        {
            if (target[i] == text[0])
            {
                found = true;
                break;
            }
        }
        if (found)
        {
            return "yes";
        }
        else
        {
            return "No";
        }
    }
    // 3.輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e。
    static string Q3(string text)
    {
        string afterText = "";
        for (int i = 0, a = text.Length; i < a; i++)
        {
            afterText += text[i];
            if (i < a - 1)
                afterText += "-";
        }
        return afterText;
    }
    // 4.輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。
    static string Q4(string text)
    {
        bool hasDot = text.Contains('.');
        string afterText = "";
        if (hasDot)
        {
            int index = text.IndexOf('.');
            for (int i = index + 1, a = text.Length; i < a; i++)
            {
                afterText += text[i];
            }
        }
        else
        {
            afterText = "你沒有輸入副檔名";
        }
        return afterText;
    }
    // 5.輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字。Length  Substring()
    static string Q5(string text)
    {
        int a = text.Length;
        string afterText = "";
        if (a < 5)
        {
            afterText = "長度不夠";
        }
        else
        {
            afterText = text.Substring(0, 3);
        }
        return afterText;
    }
    // 6.輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌。Replace()
    static string Q6(string text)
    {
        return text.Replace("我", "小明");
    }

    // 7.輸入一串字，顯示輸入幾個字。Length
    static string Q7(string text)
    {
        return $"{text.Length}個字";
    }
    // 8.(補充1)連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。
    static void Q8()
    {
        string[] arrText = new string[10];

        Console.WriteLine("請連續輸入10組數字重複了會告訴你");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"第{i + 1}次");
            string text = Console.ReadLine() ?? "";
            bool found = false;
            for (int j = 0; j < i; j++)
            {
                if (arrText[j] == text)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("輸入過");
            }
            else
            {
                Console.WriteLine("沒有輸入過");
            }
            arrText[i] = text;
        }
    }
    // 9.(補充2)用字母大小寫來模擬波浪舞的動作後輸出，比如輸入FiFa，輸出FifafIfafiFafifA
    static string Q9(string text)
    {
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < text.Length; j++)
            {
                if (i == j)
                {
                    result += char.ToUpper(text[i]);
                }
                else
                {
                    result += char.ToLower(text[j]);
                }
            }
             result += "\n";
        }
        return result;
    }
    // 10.(補充3)輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分。
    static string Q10(string text)
    {
        return text.Replace(":", "點") + "分";
    }
    // 11.(補充4)輸入的字，轉成HTML，例如輸入Justin,Amy,David 輸出<ul>	<li>Justin<li>		<li>Amy<li>	<li>David<li></ul>
    static string Q11(string text)
    {
        string[] name = text.Split(',', StringSplitOptions.RemoveEmptyEntries);
        string result = "<ul>";
        for (int i = 0, a = name.Length; i < a; i++)
        {
            result += "\n" + "\t" + "<li>" + name[i] + "</li>";
        }
        result += "\n" + "</ul>";
        return result;
    }
    // 12.(補充5)輸入5處數字，用空白隔開，輸出結果。例如：輸入‘11 19 12 25 1 7 12，輸出總和是87
    static string Q12(string text)
    {
        string[] number = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int result = 0;
        for (int i = 0, a = number.Length; i < a; i++)
        {
            result += Convert.ToInt32(number[i]);
        }
        return "總和是" + result.ToString();
    }
    // 13.(補充6)輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ
    static string Q13(string text)
    {
        string result = "";
        for (int i = text.Length-1; i >= 0; i--)
        {
            result+=text[i];
        }
        return result;
    }
}







