using UserCollectionMonths;

var month = new Months();
month[0] = new Elements("1", "January","31");
month[1] = new Elements("2", "February","29");
month[2] = new Elements("3", "March","31");
month[3] = new Elements("4", "April","30");
month[4] = new Elements("5", "May","31");
month[5] = new Elements("6", "June","30");
month[6] = new Elements("7", "July","31");
month[7] = new Elements("8", "August","31");
month[8] = new Elements("9", "September","30");
month[9] = new Elements("10", "October","31");
month[10] = new Elements("11", "November","30");
month[11] = new Elements("12", "December","31");
int number = 0;
int monthNumber = 0;
int dayLength = 0;
Console.WriteLine("Hello! if you want search month with number please press 1.");
Console.WriteLine("If you want search month with days please press 2");
number = Convert.ToInt32(Console.ReadLine());
if(number == 1)
{
    Console.WriteLine("Welcome please type month number` ");
    monthNumber = Convert.ToInt32(Console.ReadLine());
    foreach (Elements element in month)
    {
        if (monthNumber == Convert.ToInt32(element.MonthWithNumber))
        {
            Console.WriteLine("{0},{1},{2}", element.MonthWithNumber, element.Month,element.Day);
        }

    }
}

else if(number == 2)
{
    Console.WriteLine("Welcome please type Days length");
    dayLength = Convert.ToInt32(Console.ReadLine());
    foreach (Elements element in month)
    {
        if (dayLength == Convert.ToInt32(element.Day))
        {
            Console.WriteLine("{0},{1},{2}", element.MonthWithNumber, element.Month,element.Day);
        }

    }
}
