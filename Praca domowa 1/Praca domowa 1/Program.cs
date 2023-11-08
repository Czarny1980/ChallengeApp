//var number1 = 50;
//var number2 = 10;
//if(number1 < number2)
//{
// Console.WriteLine("jestem w lini 6");
//}
//else
//{
//Console.WriteLine(" jestem w lini 10");
//}

string name1 = "Ewa";
var age = 30;
string PłećMen = "M";
string PłęćWomen = "K";


if (name1 == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");

}

else
{
    if (name1 == "Ewa" && age > 33)
    {
        Console.WriteLine("Ewa jest starsza niż 33 lata");
    }
    else
    {
        if (name1 == "Ewa" && age < 33)
        {
            Console.WriteLine("Ewa jest młotrza niż 33 lata");
        }

    }
}

