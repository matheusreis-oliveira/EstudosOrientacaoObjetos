using System;
using System.Collections.Generic;
using System.Linq;
using POO.ContentContext;
using POO.SubscriptionContext;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {

            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP - Introdução", "orientacao-objetos-introducao"));
            articles.Add(new Article("Artigo sobre C#", "linguaguem-csharp"));
            articles.Add(new Article("Artigo sobre .NET", "framework-dotnet"));

            foreach (var article in articles)
            {
                Console.WriteLine("==ARTICLES==");
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
                Console.WriteLine("============");
            }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-asp-dotnet");
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            foreach (var course in courses)
            {
                Console.WriteLine("==COURSES==");
                Console.WriteLine(course.Id);
                Console.WriteLine(course.Title);
                Console.WriteLine(course.Url);
                Console.WriteLine("============");
            }

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem1 = new CareerItem(1, "Comece por aqui", "", null);
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseCsharp);
            careerDotnet.Items.Add(careerItem1);
            careerDotnet.Items.Add(careerItem2);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine("==CAREERS==");
                Console.WriteLine(career.Id);
                Console.WriteLine(career.Title);
                Console.WriteLine(career.Url);
                Console.WriteLine("============");
                foreach (var item in career.Items.OrderByDescending(x => x.Order))
                {
                    Console.WriteLine("==CAREERS ITEMS==");
                    Console.WriteLine($"{item.Order} - {item.Title} - {item.Course?.Title} ");
                    Console.WriteLine("============");
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine("==NOTIFICATIONS==");
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                        Console.WriteLine("============");
                    }
                }
            }

            var paypalSubscription = new PayPalSubscription();
            var student = new Student(); 
            student.CreateSubscription(paypalSubscription);

        }
    }
}
