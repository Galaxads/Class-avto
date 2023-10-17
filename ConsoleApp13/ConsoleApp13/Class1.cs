using System;
using System.Numerics;

public class Avto
{

    private string nom; //Номер машины m
    private float bak; //Кол-во бензина в баке
    private float ras; //Расход топлива


    public double milleage;//Пробег
                           //Текущее кол-во бензина
    private double benzseychas;
    private double rasstoykoorf(double x1, double x2, double y1, double y2)
    {
        double itog = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine(itog);
        return itog;
    }
      
    public void info(string nom, float bak, float ras) //Конструктор класса
    {
        this.nom = nom;
        this.bak = bak;
        this.ras = ras;

        this.benzseychas = 0;
        this.milleage = 0;
    }
    //Вывод информации
    public void Out()
    {
        Console.WriteLine($"Вся информация о машине \nНомер машины:{nom}  \nРазмер бака:{bak} \nРасход топлива на 100км:{ras}");
    }
    //Заправка
    public double Zapravka()
    {

        Console.WriteLine($"Введите кол-во бензина (в литрах), на которое хотите заправить машину (макс значение:{bak}).");
        double popolbenz = Convert.ToDouble(Console.ReadLine());
        if (benzseychas + popolbenz <= bak)
        {
            benzseychas += popolbenz;
            Console.WriteLine($"Машина заправлена на {popolbenz} литров. Текущее количество топлива: {benzseychas} литров.");

        }
        else
        {
            Console.WriteLine("Бак машины переполнен. Невозможно добавить больше топлива.");
        }
        return benzseychas;
    }

    //Цикл езды
    public void Drive(double distnace)
    {
        double rasstoyanie = distnace;
        double x1 = 1;
        double x2 = 0;
        double y1 = 1;
        double y2 = 0;
        while (milleage < distnace)
        {
            if (benzseychas < ras)
            {
                Console.WriteLine($"Недостаточно топлива для прохождения {rasstoyanie} км. Пожалуйста, заправьте машину.");
                this.Zapravka();

            }
          
            benzseychas -= ras;
            milleage += 100;
            x2 += 100;
            y2 += 100;
            if (benzseychas < 0)
            {
                Console.WriteLine($"Топливо закончилось");
                return;
            }
            Console.WriteLine($"Пройдено {milleage} км. Пробег: {milleage}. Остаток топлива: {benzseychas} литров.");
            
        }
        this.rasstoykoorf(x1,x2,y1,y2);

    }
    public void speedUp(int speed)
    {
        speed += 50;
    }
    public void speeddown(int speed)
    {  
        speed -= 50;
    }
}


