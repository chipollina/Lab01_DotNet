// int age = 20;
// double gpa = 4.5;
// bool isStudent = true;
// string name = "Иван";

// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(gpa);
// Console.WriteLine(isStudent);
string firstName = "Полина";
string lastName = "Домрачева";
string group = "Исп-241";
int birthdayYear = 2008;
double gpa = 4;
bool hasScholarship = true;
int currentYear = 2026;
int age = currentYear - birthdayYear;
Console.WriteLine("Студенческое удостоверение");
Console.WriteLine($"Имя:{firstName} {lastName}");
Console.WriteLine($"группа:{group}");
Console.WriteLine($"возраст:{age} лет");
Console.WriteLine($"средний балл:{gpa} ");
Console.WriteLine($"стипендия:{hasScholarship}");
Console.Write("\nВведите ваш любимый предмет: ");
string subject = Console.ReadLine();
Console.WriteLine($"Отлично! {firstName} любит {subject}. ");

