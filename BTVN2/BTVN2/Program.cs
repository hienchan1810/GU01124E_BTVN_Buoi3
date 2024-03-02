// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        string[] Hocvien = { "A", "B", "C", "D", "E" };
        double[] diem = { 3.8, 3.5, 6.5, 7.9, 7.8 };

        for (int i = 0; i < Hocvien.Length; i++)
        {
            double diemlamtron = Roundscore(diem[i]);
            string rank = XepHang(diemlamtron);
            Console.WriteLine(Hocvien[i] + " " + diemlamtron + " => " + rank);

        }
    }
    static double Roundscore(double d)
    {
        if (d < 3.5)
        {
            return d;

        }
        else
        {
            double lamtronlen = Math.Ceiling(d);
            double lamtronxuong = Math.Floor(d);

            if (d - lamtronxuong == 0.5)
            {
                return d;
            }
            else if (d + 0.2 > lamtronlen)
            {
                return lamtronlen;
            }
            else
            {
                return lamtronxuong;
            }
        }
    }
    static string XepHang(double d)
    {
        switch ((int)d)
        {
            case var _ when d < 4:
                return "Hoc lai";
            case var _ when d >= 4 && d < 6:
                return "Trung binh";
            case var _ when d >= 6 && d < 8:
                return "Kha";
            case var _ when d >= 8:
                return "Gioi";
            default:
                return "khong dat";

        }
    }


}
