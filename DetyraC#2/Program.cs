using System;

class Puntor
{

    public int Id { get; set; }
    public string Emri { get; set; }
    public string Pozita { get; set; }
    public double Rroga { get; set; }

    public virtual double Kalkulimi_i_bonusit(double rroga)
    {
        return 50000;
    }

}

class Zhvillues : Puntor
{

    public override double Kalkulimi_i_bonusit(double rroga)
    {
        double bonus = rroga * 2.0;
        if (bonus < 50000)
        {
            bonus = 50000;
        }

        return bonus;

    }

}


class Menaxher : Puntor
{

    public override double Kalkulimi_i_bonusit(double rroga)
    {
        double bonus = rroga * 2.5;
        if (bonus < 50000)
        {
            bonus = 50000;
        }
        return bonus;
    }

}

class Admin : Puntor
{

    public override double Kalkulimi_i_bonusit(double rroga)
    {
        return 50000;
    }

}




class program
{
    public static void Main(string[] args)
    {
        Zhvillues zhvillues = new Zhvillues();
        Console.WriteLine("Punonjësi 1:");
        Console.Write("ID: ");
        zhvillues.Id = int.Parse(Console.ReadLine());
        Console.Write("Emri: ");
        zhvillues.Emri = Console.ReadLine();
        Console.Write("Pozita: ");
        zhvillues.Pozita = Console.ReadLine();
        Console.Write("Rroga: ");
        zhvillues.Rroga = double.Parse(Console.ReadLine());

        Menaxher menaxher = new Menaxher();
        Console.WriteLine("\nPunonjësi 2:");
        Console.Write("ID: ");
        menaxher.Id = int.Parse(Console.ReadLine());
        Console.Write("Emri: ");
        menaxher.Emri = Console.ReadLine();
        Console.Write("Pozita: ");
        menaxher.Pozita = Console.ReadLine();
        Console.Write("Rroga: ");
        menaxher.Rroga = double.Parse(Console.ReadLine());

        Admin admin = new Admin();
        Console.WriteLine("\nPunonjësi 3:");
        Console.Write("ID: ");
        admin.Id = int.Parse(Console.ReadLine());
        Console.Write("Emri: ");
        admin.Emri = Console.ReadLine();
        Console.Write("Pozita: ");
        admin.Pozita = Console.ReadLine();
        Console.Write("Rroga: ");
        admin.Rroga = double.Parse(Console.ReadLine());

        

        
    }
}
