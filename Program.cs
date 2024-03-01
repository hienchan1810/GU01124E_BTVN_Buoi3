// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Console.WriteLine("Nhap ngay gio 12 h theo dinh dang 12:00:01 AM ");
        string time12hInput = Console.ReadLine();
        try
        {
            string time24hOutput = Convert12hto24h(time12hInput);
            Console.WriteLine("24 h tuong ung la " + time24hOutput);

        }
        catch (Exception ex)
        {
            Console.WriteLine("Dinh dang khong hop le. Vui long nhap lai");

        }
    }
    static string Convert12hto24h(string time12h)
    {
        string[] tachgio = time12h.Split(':', ' ', 'M');
        int hh = int.Parse(tachgio[0]);
        int mm = int.Parse(tachgio[1]);
        int ss = int.Parse(tachgio[2]);
        if (time12h.Contains("PM") && hh != 12)
        {
            hh += 12;
        }
        else if (time12h.Contains("AM") && hh == 12)
        {
            hh = 0;
        }
        string gio = hh.ToString("00");
        string phut = mm.ToString(":00");
        string giay = ss.ToString(":00");

        string time24h = gio + phut + giay;
        return time24h;
    }
}

