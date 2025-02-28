string studentName = Console.ReadLine();

int expelsCount = 0;
int yearsCount = 0;
double gradesSum = 0;
while (expelsCount<2 && yearsCount<12)
{
    double grade = double.Parse(Console.ReadLine());
    yearsCount++;
    if(grade<4)
    {
        expelsCount++;
        continue;
    }
    else
    {
        gradesSum+= grade;
    }

}

if(expelsCount<2)
{
    Console.WriteLine($"{studentName} graduated. Average grade: {gradesSum/yearsCount:f2}");
}
else
{
    Console.WriteLine($"{studentName} has been excluded at {yearsCount-1} grade");
}