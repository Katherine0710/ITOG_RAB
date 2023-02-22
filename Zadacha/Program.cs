internal class Program
{
    private static void Main(string[] args)
    {
        string[] mass = new string[100];
        for (int c = 0; c < 100; c++)
        {
            mass[c] = "0";
        }
        int j = 0;
        while (j < 100)
        {
            Console.Write("Введите текст или 0 для завершения:");
            string? s = Console.ReadLine();
            while (s == null)
            {
                s = Console.ReadLine();
            }
            try
            {
                if (Convert.ToInt32(s) == 0)
                {
                    break;
                }
                mass[j] = s;
            }
            catch
            {
                mass[j] = s;
            }
            j++;
        }

        int NewMassLen = 0;

        for (int i = 0; i < mass.Length; i++)
        {
            if (StringLen(mass[i]) <= 3 && mass[i] != "0")
            {
                NewMassLen++;
            }
        }

        string[] NewMass = new string[NewMassLen];
        int n = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            if (StringLen(mass[i]) <= 3 && mass[i] != "0")
            {
                NewMass[n] = mass[i];
                n++;
            }
        }

        foreach (string o in NewMass)
        {
            Console.WriteLine(o);
        }

        int StringLen(string text)
        {
            int m = 0;
            foreach (char n in text)
            {
                m++;
            }
            return m;
        }
    }
}