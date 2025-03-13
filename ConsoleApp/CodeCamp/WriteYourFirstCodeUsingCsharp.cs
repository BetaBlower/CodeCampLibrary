using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CodeCamp
{
    public class WriteYourFirstCodeUsingCsharp
    {
        public class PerformBasicStringFormattinginCsharp
        {
            public void SecondPart()
            {
                Console.WriteLine(@"Using ---> '\n' ");
                Console.WriteLine("Hello\nWorld!");
                Console.WriteLine("\n");
                Console.WriteLine(@"Using ---> '\t' ");
                Console.WriteLine("Hello\tWorld!");
                //
                Console.WriteLine("\n");
                Console.WriteLine("Hello \"World\"!");
                //
                Console.WriteLine("\n");
                Console.WriteLine("c:\\source\\repos");
                //
                Console.WriteLine("\n");
                Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
                Console.WriteLine("Invoice: 1021\t\tComplete!");
                Console.WriteLine("Invoice: 1022\t\tComplete!");
                Console.WriteLine("\nOutput Directory:\t");
                //
                Console.WriteLine("\n");
                Console.WriteLine(@"    c:\source\repos    
(this is where your code goes)");
                //
                Console.WriteLine("\n");
                Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
                //
                Console.WriteLine("\n");
                Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
                Console.WriteLine(@"c:\invoices\app.exe -j");

            }
            public void ThirdPart()
            {

                Console.WriteLine("\n");
                string firstName = "Bob";
                string greeting = "Hello";
                Console.WriteLine(greeting + " " + firstName + "!");
            }
            public void FourthPart()
            {
                int version = 11;
                string updateText = "Update to Windows";
                Console.WriteLine($"{updateText} {version}!");
                //
                Console.WriteLine("\n");
                string projectName = "First-Project";
                Console.WriteLine($@"C:\Output\{projectName}\Data");

            }
            public void FifthPart()
            {
                string projectName = "ACME";
                string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

                Console.WriteLine($"View English output:\n\tc:\\Exercise\\{projectName}\\data.txt");
                Console.WriteLine($"{russianMessage}t:\n\tc:\\Exercise\\{projectName}\\data.txt");
            }

        }
        public class PerformBasicOperationsOnNumbersinCsharp
        {
            public void ThirdPart()
            {
                int sum = 7 + 5;
                int difference = 7 - 5;
                int product = 7 * 5;
                int quotient = 7 / 5;

                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Difference: " + difference);
                Console.WriteLine("Product: " + product);
                Console.WriteLine("Quotient: " + quotient);
                //
                Console.WriteLine();

                decimal decimalQuotient = 7.0m / 5;
                Console.WriteLine($"Decimal quotient: {decimalQuotient}");
                //
                Console.WriteLine();

                int first = 7;
                int second = 5;
                decimal quotient2 = (decimal)first / (decimal)second;
                Console.WriteLine(quotient2);
                //
                Console.WriteLine();

                Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
                Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");
            }
            public void FourthPart()
            {
                int value = 0;     // value is now 0.
                value = value + 5; // value is now 5.
                value += 5;        // value is now 10.
                //
                int value2 = 0;     // value is now 0.
                value2 = value + 1; // value is now 1.
                value2++;           // value is now 2.

                //
                int value3 = 1;

                value3 = value3 + 1;
                Console.WriteLine("First increment: " + value);

                value3 += 1;
                Console.WriteLine("Second increment: " + value);

                value3++;
                Console.WriteLine("Third increment: " + value);

                value3 = value3 - 1;
                Console.WriteLine("First decrement: " + value);

                value3 -= 1;
                Console.WriteLine("Second decrement: " + value);

                value3--;
                Console.WriteLine("Third decrement: " + value);
                value3++;
                
            }
            public void FifthPart()
            {
                int fahrenheit = 94;
                Console.WriteLine($"The temperature is {(decimal)(fahrenheit-32)*5/9} Celsius.");
            }
            public void SixthPart()
            {

            }
            public void SeventhPart()
            {

            }
            public void EighthPart()
            {

            }
            public void NinethPart()
            {

            }
        }
        public class GuidedProjectCalculateAndPrintStudentGrades
        {
            public void SecondPart()
            {
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


                int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
                int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
                int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
                int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

                decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
                decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
                decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
                decimal jeongScore = (decimal)jeongSum / currentAssignments;

                Console.WriteLine("Student\tGrade\n");
                Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
                Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
                Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
                Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");





            }
        }
        public class GuidedProjectCalculateFinalGPA

        {
            public void SecondPart()
            {
                string studentName = "Sophia Johnson";
                string course1Name = "English 101";
                string course2Name = "Algebra 101";
                string course3Name = "Biology 101";
                string course4Name = "Computer Science I";
                string course5Name = "Psychology 101";

                int course1Credit = 3;
                int course2Credit = 3;
                int course3Credit = 4;
                int course4Credit = 4;
                int course5Credit = 3;

                int gradeA = 4;
                int gradeB = 3;

                int course1Grade = gradeA;
                int course2Grade = gradeB;
                int course3Grade = gradeB;
                int course4Grade = gradeB;
                int course5Grade = gradeA;

                int totalCreditHours = 0;
                totalCreditHours += course1Credit;
                totalCreditHours += course2Credit;
                totalCreditHours += course3Credit;
                totalCreditHours += course4Credit;
                totalCreditHours += course5Credit;

                int totalGradePoints = 0;
                totalGradePoints += course1Credit * course1Grade;
                totalGradePoints += course2Credit * course2Grade;
                totalGradePoints += course3Credit * course3Grade;
                totalGradePoints += course4Credit * course4Grade;
                totalGradePoints += course5Credit * course5Grade;

                decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

                int leadingDigit = (int)gradePointAverage;
                int firstDigit = (int)(gradePointAverage * 10) % 10;
                int secondDigit = (int)(gradePointAverage * 100) % 10;

                Console.WriteLine($"Student: {studentName}\n");
                Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

                Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
                Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
                Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
                Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
                Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");

                Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");
            }
            
        }
    }
}
