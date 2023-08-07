// See https://aka.ms/new-console-template for more information
using LinqTest;


var studentList = new Student[]
{
    new Student() {Id = 1, Name = "Damex", Mark = 73, City = "NYC"},
    new Student() {Id = 2, Name = "Duy", Mark = 49, City = "CA"},
    new Student() {Id = 3, Name = "Veamx", Mark = 88, City = "CA"},
    new Student() {Id = 4, Name = "Vy", Mark = 89, City = "NYC"},
    new Student() {Id = 5, Name = "Mia", Mark = 85, City = "NYC"},
};

Student studentFoundById = studentList.Where(student => student.Id == 4).Select(student => student).First();
Console.WriteLine("Student: {0} {1} {2} {3}", 
    studentFoundById.Id, 
    studentFoundById.Name, 
    studentFoundById.Mark, 
    studentFoundById.City);

List<Student> studentListAm = studentList.Where(student => student.Name.Contains("am")).ToList();
studentListAm.ForEach(student => 
    Console.WriteLine("Student: {0} {1} {2} {3}",
    student.Id,
    student.Name,
    student.Mark,
    student.City));

int highMark = studentList.Max(x => x.Mark);
Student highMarkStudent = studentList.Where(studentList=> studentList.Mark == highMark).First();

Console.WriteLine("Student: {0} {1} {2} {3}",
    highMarkStudent.Id,
    highMarkStudent.Name,
    highMarkStudent.Mark,
    highMarkStudent.City);

Student highMarkStu = studentList.OrderByDescending(student => student.Mark).First();
Console.WriteLine("Student: {0} {1} {2} {3}",
    highMarkStu.Id,
    highMarkStu.Name,
    highMarkStu.Mark,
    highMarkStu.City);

bool bigger50 = studentList.All(student => student.Mark > 50);
Console.WriteLine(bigger50 ? "Pass" : "Fail");