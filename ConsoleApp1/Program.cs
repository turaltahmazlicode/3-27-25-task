using CarTask;
using StudentTask;

namespace ConsoleApp1
{
    internal class Program
    {
        #region task1
        static void Task1()
        {
            static void AddToStudentArray(ref Student[] students, Student student)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
            Student[] students = new Student[0];
            Student student1 = new("Tural", "turaltahmazli@outlook.com", 100);
            Student student2 = new("Tural", "turaltahmazli7@gmail.com", 100);
            AddToStudentArray(ref students, student1);
            AddToStudentArray(ref students, student2);
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
        #endregion
        #region task2
        /*
1.Car(Maşın) adlı bir class yaradın. Bu class aşağıdakı propertilərə sahib olmalıdır:
Brand(string) – Məsələn: "Mercedes"
Model(string) – Məsələn: "S-Class Maybach"
Price(decimal) – Məsələn: 350000
Year(int) – Zavod buraxılış ili.Məsələn: 2023
Color(string) – Məsələn: "Qara"

2. CarSalon(Maşın salonu) adlı bir class yaradın. Bu class daxilində :
Maşınlardan ibarət bir array saxlayın.
Aşağıdakı metodları yazın edin:

Əməliyyatlar:
GetAllCars() → Maşın salonundakı bütün maşınların siyahısını qaytarsın.
GetCarCount() → Maşın salonunda neçə maşın olduğunu qaytarsın.
GetTotalValue() → Maşın salonundakı bütün maşınların ümumi qiymətini qaytarsın.
FilterByBrand(string brand) → Verilmiş branda uyğun maşınları qaytarsın.
FilterByModel(string model) → Verilmiş modelə uyğun maşınları qaytarsın.
FilterByColor(string color) → Verilmiş rəngə uyğun maşınları qaytarsın.
FilterByPriceRange(decimal min, decimal max) → Verilmiş qiymət aralığında olan maşınları qaytarsın.
*/
        static void Task2()
        {
            Car car1 = new Car("Mercedes", "S-Class Maybach", 100000, 2023, "Qara");
            Car car2 = new Car("Mercedes", "S-Class Maybach", 200000, 2023, "Qara");
            Car car3 = new Car("Mercedes", "S-Class Maybach", 300000, 2023, "Qara");
            Car car4 = new Car("Mercedes", "S-Class Maybach", 400000, 2023, "Qara");
            Car car5 = new Car("Mercedes", "S-Class Maybach", 500000, 2023, "Qara");
            CarShowroom carShowroom = new CarShowroom([car1, car2, car3, car4, car5]);
            carShowroom.GetCarsByPriceRange(200000, 450000).DisplayCarShowroom();
        }
        #endregion
        static void Main(string[] args)
        {
            Task2();
        }
    }
}
