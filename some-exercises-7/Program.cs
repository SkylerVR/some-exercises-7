// შექმენით კლასი, "Person" შემდეგი property ებით: "Name" (string) და "Age" (int). შექმენით  კონსტრუქტორი, რ
// ომელიც მიანიჭებს პირველად მნიშვნელობებს ორივე property-ს. შექმენით "Person" კლასის ობიექტი და დაბეჭდეთ მისი property ების მნიშვნელობები.
//     Person კლასში დაამატეთ ახალი უპარამეტრო კონსტრუქტური , რომელიც "Name" -ს ანიჭებს "NoName" ს ხოლო "Age" 0 - ს .
//     შექმენით კლასი BankAccount, რომელსაც ექნება ანგარიშის ნომერი, ვალუტა და decimal ტიპის ბალანსი,
// შექმენის კლასის ობიექტები, და მიანიჭეთ მნიშვნელობები, კონსოლში დაბეჭდეთ ანგარიშის ნომერი;

using some_exercises_7;

Person person = new Person("tsds",22);
Person person1 = new Person();
Console.WriteLine(person.Name + person.Age);
Console.WriteLine(person1.Name + person1.Age);

BankAccount bankAccount = new BankAccount("USD", "TEST", 3220.233m);
Console.WriteLine(bankAccount.Iban);
Console.WriteLine(bankAccount.Currency);
Console.WriteLine(bankAccount.Amount);

Student student = new Student("Alex","Doe",80.0);
Console.WriteLine($"{student.Name} {student.LastName} {student.GPA}");

