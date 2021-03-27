using System;

var pole1 = new char []{ '7', '8' ,'9' };
var pole2 = new char[] { '4', '5', '6' };
var pole3 = new char[] { '1', '2', '3' };
int vyb = 0;
char hod = 'X';
char sledhod = 'O';
char temp = '0';

while (true)
{
    VyvPole(pole1, pole2, pole3);
    Hod(hod);
    vyb = Convert.ToInt32(Console.ReadLine());
    if (vyb == 1)
        pole3[0] = hod;
    else if (vyb == 2)
        pole3[1] = hod;
    else if (vyb == 3)
        pole3[2] = hod;
    else if (vyb == 4)
        pole2[0] = hod;
    else if (vyb == 5)
        pole2[1] = hod;
    else if (vyb == 6)
        pole2[2] = hod;
    else if (vyb == 7)
        pole1[0] = hod;
    else if (vyb == 8)
        pole1[1] = hod;
    else if (vyb == 9)
        pole1[2] = hod;
    else
        Console.WriteLine("Error");
        Console.ReadKey();


    if ((pole1[0] == hod & pole1[1] == hod & pole1[2] == hod) ^ (pole2[0] == hod & pole2[1] == hod & pole2[2] == hod) ^ (pole3[0] == hod & pole3[1] == hod & pole3[2] == hod))
    {
        break;
    }
    if ((pole1[0] == hod & pole2[0] == hod & pole3[0] == hod) ^ (pole1[1] == hod & pole2[1] == hod & pole3[1] == hod) ^ (pole1[2] == hod & pole2[2] == hod & pole3[2] == hod))
    {
        break;
    }
    if ((pole1[0] == hod & pole2[1] == hod & pole3[2] == hod) ^ (pole1[2] == hod & pole2[1] == hod & pole3[0] == hod))
    {
        break;
    }
    temp = hod;
    hod = sledhod;
    sledhod = temp; 
}

Console.WriteLine("Выиграли " + hod + "!");
Console.ReadKey();

static void VyvPole(char[] pole1, char[] pole2, char[] pole3)
{
    Console.Clear();
    foreach (char i in pole1)
        Console.Write(i + " ");
    Console.Write("\n");
    foreach (char i in pole2)
        Console.Write(i + " ");
    Console.Write("\n");
    foreach (char i in pole3)
        Console.Write(i + " ");
    Console.Write("\n");
}
static void Hod(char hod)
{
    Console.WriteLine("Ходят " + hod);
}