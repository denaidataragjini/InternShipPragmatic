using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Student
    {

        public string name { get; set; }
        public string surname { get; set; }
        public string className { get; set; }
        public int grade { get; set; }

        public Student(string name, string surname, string className, int grade)
        {
            this.name = name;
            this.surname = surname;
            this.className = className;
            this.grade = grade;
        }


    }


    class Program
    {
        static void Main()

        { //Te dhenat i vendosa manualisht duke e mbushur vete listen me inpute.
            List<Student> students = new List<Student>()
            {
               new Student("Andi", "Visari", "10A", 80),
               new Student("Evis", "Ajazi", "10A", 67),
              new Student("Genti", "Agolli", "11A", 92),
             new Student("Endri", "Drita", "10A", 47),
           new Student("Erion", "Shehu", "11A", 90)   };


            //variabla qe do te na duhen per te llogaritur mesataren me te larte nga klasat
            int firstClassGradesSum = 0;
            int secondClassGradesSum = 0;
            string firstClassName = "";
            string secondClassName = "";
            double firstClassAverage = 0.0;
            double secondClassAverage = 0.0;
            int firstClassCounter = 0;
            int secondClassCounter = 0;

            firstClassName = students[0].className; //marrim emrin e klases se pare

            //Duke qene se te dhenat i vendosa vete ne liste bejme nje kontroll si fillim per inputet:
            foreach (Student student in students)
            {
                if (student.name.Length > 15 || student.surname.Length > 15)
                {
                    Console.WriteLine("Your Name length is too long, please update the information");
                    break;
                }
                else

                if (student.className.Length > 3)

                {
                    Console.WriteLine("Your student class name must contain only 3 charachters, please update the information");
                    break;
                }
                if (student.grade < 1 || student.grade > 100)
                {
                    Console.WriteLine("Your student grade must be 1-100, please update the information");
                    break;
                }
                else
                //ketu do te marrim shumen e notave te cdo klase 
                {
                    if (student.className == firstClassName)
                    {
                        firstClassGradesSum += student.grade;
                        firstClassName = student.className;
                        firstClassCounter += 1;
                    }
                    else
                    {
                        secondClassGradesSum += student.grade;
                        secondClassName = student.className;
                        secondClassCounter += 1;
                    }



                }
            
            }
            //Ne rast senuk kemi asnje gabim ne vendosjen e te dhenave atehere do  te vazhdojme me gjetjen e Mesatares
            firstClassAverage = Convert.ToDouble(firstClassGradesSum) / firstClassCounter;
            secondClassAverage = Convert.ToDouble(secondClassGradesSum) / secondClassCounter;

            if (firstClassAverage > secondClassAverage)
            {
                Console.WriteLine("{0} {1}", firstClassName, firstClassAverage);

            }
            else
            {
                Console.WriteLine("{0} {1}", secondClassName, secondClassAverage);

            }

            Console.ReadKey();
        }
    }
}
