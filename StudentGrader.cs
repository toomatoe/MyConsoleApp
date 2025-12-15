// initialize variables - graded assignments 
int currentAssignments = 5;
int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

// calculate average grades

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
decimal sophiaAvg = (decimal) sophiaSum / currentAssignments;
decimal nicolasAvg = (decimal) nicolasSum / currentAssignments;
decimal zahirahAvg = (decimal) zahirahSum / currentAssignments;
decimal jeongAvg = (decimal) jeongSum / currentAssignments;

// function to determine letter grade
string letterGrade(decimal avgGrade)
{
     
    if (avgGrade >= 97)
    {
        return " A+";
    }
    else if (avgGrade >= 93)
    {
        return " A";
    }
    else if (avgGrade >= 90)
    {
        return " A-";
    }
    else if (avgGrade >= 87)
    {
        return " B+";
    }
    else if (avgGrade >= 83)
    {
        return " B";

}
    else if (avgGrade >= 80)
    {
        return " B-";
    }
    else if (avgGrade >= 77)
    {
        return " C+";
    }
    else if (avgGrade >= 73)
    {
        return " C";
    }
    else if (avgGrade >= 70)
    {
        return " C-";
    }
    else if (avgGrade >= 67)
    {
        return " D+";
    }
    else if (avgGrade >= 63)
    {
        return " D";
    }
    else if (avgGrade >= 60)
    {
        return " D-";
    }
    else
    {
        return " F";
    }
}

// display average grades
Console.WriteLine("Student\tGrade\n");
Console.WriteLine("Sophia\t" + sophiaAvg + letterGrade(sophiaAvg));
Console.WriteLine("Nicolas\t" + nicolasAvg + letterGrade(nicolasAvg));
Console.WriteLine("Zahirah\t" + zahirahAvg + letterGrade(zahirahAvg));
Console.WriteLine("Jeong\t" + jeongAvg + letterGrade(jeongAvg));