using System;

var pole1 = new char []{ '7', '8' ,'9' };
var pole2 = new char[] { '4', '5', '6' };
var pole3 = new char[] { '1', '2', '3' };
int vyb = 0;
char hod = 'X';
char sledhod = 'O';
char temp = '0';
int pob = 0;
int count_x = 0;
int count_o = 0;

while (true)
{
    while (true)
    {
        VyvPole(pole1, pole2, pole3);
        Hod(hod);
        vyb = Convert.ToInt32(Console.ReadLine());
        switch (vyb)
        {
            case 1:
                pole3[0] = hod;
                break;
            case 2:
                pole3[1] = hod;
                break;
            case 3:
                pole3[2] = hod;
                break;
            case 4:
                pole2[0] = hod;
                break;
            case 5:
                pole2[1] = hod;
                break;
            case 6:
                pole2[2] = hod;
                break;
            case 7:
                pole1[0] = hod;
                break;
            case 8:
                pole1[1] = hod;
                break;
            case 9:
                pole1[2] = hod;
                break;
            default:
                Console.WriteLine("Error");
                Console.ReadKey();
                break;
        }
        pob = Pobeda(pole1, pole2, pole3, hod);
        if (pob == 1)
            break;
        temp = hod;
        hod = sledhod;
        sledhod = temp;
    }

    Console.WriteLine("Выиграли " + hod + "!");
    if (hod == 'X')
    {
        count_x++;
        Console.WriteLine("X" + " выиграли " + count_x + " раз");
    }
    else
    {
        count_o++;
        Console.WriteLine("X" + " выиграли " + count_x + " раз");
    }
    Console.ReadKey();
    pole1[0] = '7'; pole1[1] = '8'; pole1[2] = '9';
    pole2[0] = '4'; pole2[1] = '5'; pole2[2] = '6';
    pole3[0] = '1'; pole3[1] = '2'; pole3[2] = '3';
}

static void VyvPole(char[] pole1, char[] pole2, char[] pole3)
{
    Console.Clear();
    foreach (char i in pole1)
        Console.Write(i + "\t ");
    Console.Write("\n\n\n\n");
    foreach (char i in pole2)
        Console.Write(i + "\t ");
    Console.Write("\n\n\n\n");
    foreach (char i in pole3)
        Console.Write(i + "\t ");
    Console.Write("\n\n\n\n");
}
static void Hod(char hod)
{
    Console.WriteLine("Ходят " + hod);
}
static int Pobeda(char[] pole1, char[] pole2, char[] pole3, char hod)
{
    if ((pole1[0] == hod & pole1[1] == hod & pole1[2] == hod) ^ (pole2[0] == hod & pole2[1] == hod & pole2[2] == hod) ^ (pole3[0] == hod & pole3[1] == hod & pole3[2] == hod))
        return 1;
    else if ((pole1[0] == hod & pole2[0] == hod & pole3[0] == hod) ^ (pole1[1] == hod & pole2[1] == hod & pole3[1] == hod) ^ (pole1[2] == hod & pole2[2] == hod & pole3[2] == hod))
        return 1;
    else if ((pole1[0] == hod & pole2[1] == hod & pole3[2] == hod) ^ (pole1[2] == hod & pole2[1] == hod & pole3[0] == hod))
        return 1;
    else return 0;
}