
using Domain.Models;
using Infrastructure.Services;

var stdService = new StudentService();
var grService = new GroupServices();
var mentorService = new MentorService();
var courseService = new CourseServices();
var course_grService = new Course_GroupServices();
var mentor_courseService = new Mentor_CourseService();
var std_grService = new Student_GroupServices();


// var std = new Student()
// {
//     FirstName = "Test3",
//     LastName = "Testov3",
//     Age = 3,
//     Address = "Dushanbe",
//     Email = "Testov3@gmail.com"

// };
// stdService.AddStudent(std);
// foreach (var item in stdService.GetStudents())
// {
//     System.Console.WriteLine(item.Id);
//     System.Console.WriteLine(item.FirstName);
//     System.Console.WriteLine(item.LastName);
//     System.Console.WriteLine(item.Address);
//     System.Console.WriteLine(item.Email);
// }
    
// var group = new Group()
// {
//     Name = "CSS",
//     Members = 12
// };
// grService.AddGroup(group);

// var mentor = new Mentor()
// {
//     FirstName = "MAruf",
//     LastName = "MA",
//     Experience = 1
// };

// mentorService.AddMentor(mentor);

// var course = new Course()
// {  
//     Name = ".Test4",
//     Description = "Testov4"
// };

// courseService.AddCourse(course);

// var mentor_course = new Mentor_Course()
// {
//     Mentor_Id = 3,
//     Course_Id = 4
// };

// mentor_courseService.AddMentor_Course(mentor_course);

// var course_group = new Course_Groups()
// {
//     Course_Id = 3,
//     Group_Id = 4
// };
// course_grService.AddCourse_Group(course_group);

// var student_group = new Student_Group()
// {
//     Student_Id = 3,
//     Group_Id = 3
// };

// std_grService.AddStudent_Group(student_group);