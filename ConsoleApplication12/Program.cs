using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            string id, name, street1, street2, city, area, pincode, email, contactNumber, linkURL, slack, facebook, twitter,newId;
            int emp, horDev,n, flag = 0;
            
            
            Employee e = new Hr();
            List<Employee> a1 = new List<Employee>();
            Console.WriteLine("enter the no of employee inputs you want to make");
            emp = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < emp; i++)
            {
                Console.WriteLine("what type of employee enter 1 for hr and 2 for developer");
                horDev = Convert.ToInt32(Console.ReadLine());
                switch (horDev)
                {
                    case 1: Console.WriteLine("enter the id");
                        id = Console.ReadLine();
                        Console.WriteLine("enter the name");
                        name = Console.ReadLine();
                        Console.WriteLine("enter the street1");
                        street1 = Console.ReadLine();
                        Console.WriteLine("enter the street2");
                        street2 = Console.ReadLine();
                        Console.WriteLine("enter the city");
                        city = Console.ReadLine();
                        Console.WriteLine("enter the area");
                        area = Console.ReadLine();
                        Console.WriteLine("enter the pincode");
                        pincode = Console.ReadLine();
                        Console.WriteLine("enter the email");
                        email = Console.ReadLine();
                        Console.WriteLine("enter the contact no");
                        contactNumber = Console.ReadLine();
                        Console.WriteLine("enter the linked in url");
                        linkURL = Console.ReadLine();
                        Hr p = new Hr();

                        p.Register(id, name, street1, street2, city, area, pincode, email, contactNumber, linkURL);

                        
                        
                Console.WriteLine("do you want to display anyones details If yes type 1 else type 2");
                int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the id of the employement whose details you want");
                        newId = Console.ReadLine();
                        a1 = p.display(newId, id, name, street1, street2, city, area, pincode, email, contactNumber, linkURL);

                    
                        

                        break;
                    case 2: Console.WriteLine("enter the id");
                        id = Console.ReadLine();
                        Console.WriteLine("enter the name");
                        name = Console.ReadLine();
                        Console.WriteLine("enter the street1");
                        street1 = Console.ReadLine();
                        Console.WriteLine("enter the street2");
                        street2 = Console.ReadLine();
                        Console.WriteLine("enter the city");
                        city = Console.ReadLine();
                        Console.WriteLine("enter the area");
                        area = Console.ReadLine();
                        Console.WriteLine("enter the pincode");
                        pincode = Console.ReadLine();
                        Console.WriteLine("enter the slack account ");
                        slack = Console.ReadLine();
                        Console.WriteLine("enter the facebook pages");
                        facebook = Console.ReadLine();
                        Console.WriteLine("enter the twitter pages");
                        twitter = Console.ReadLine();
                        Developer d = new Developer(id, name, street1, street2, city, area, pincode, slack, facebook, twitter);

                        d.Register();
                Console.WriteLine("do you want to display anyones details If yes type 1 else type 2");
                int  x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the id of the employement whose details you want");
                 newId = Console.ReadLine();
                a1 = d.display(newId);


                        break;

                }


                foreach (Employee b in a1)
                {



                    Console.Write(b.id);
                    Console.WriteLine(b.name);
                    Console.WriteLine(b.street1);
                    Console.WriteLine(b.street2);
                    Console.WriteLine(b.city);
                    Console.WriteLine(b.area);
                    Console.WriteLine(b.pincode);
                    Console.WriteLine(((Hr)b).email);
                    Console.WriteLine(((Hr)b).contactNumber);
                    Console.WriteLine(((Hr)b).linkURL);
                    Console.WriteLine(((Developer)b).slack);
                    Console.WriteLine(((Developer)b).facebook);
                    Console.WriteLine(((Developer)b).twitter);
                    Console.ReadKey();
                }

            }
           /* if (n == 1)
            {
                Console.WriteLine("which type of employee you want to search if hr enter 1 else enter2");
                int v = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("details added are:");*/
              
                   
                
        
                
            }
        }
    public class Employee
    {
        public string id, name, street1, street2, city, area, pincode;
      
        
    }

    
        public class Hr:Employee
        {
            public string  email, contactNumber, linkURL;

            List<Employee> a1 = new List<Employee>();
            public  void Register(string id, string name, string street1, string street2, string city, string area, string pincode, string email, string contactNumber, string linkURL)
            {

                
                Hr p = new Hr();
                
                p.id = id;

                p.name = name;
                p.city = city;
                p.street1 = street1;
                p.street2 = street2;
                p.area = area;
                p.pincode = pincode;
                p.email = email;
                p.contactNumber = contactNumber;
                p.linkURL = linkURL;
                a1.Add(p);


            }
            public void Register()
            {
                Console.WriteLine("");
            }
            public List<Employee> display(string newId,string id, string name, string street1, string street2, string city, string area, string pincode, string email, string contactNumber, string linkURL)
            {
                if (newId == id)
                {
                    return a1;
                }
                else
                {
                    return new List<Employee>();
                }
            }
            ~Hr()
            {

            }
        }
        public class Developer:Employee
        {
            public string id, name, street1, street2, city, area, pincode, slack, facebook, twitter;
            List<Employee> a1 = new List<Employee>();

            public Developer()
            {
            }
            public Developer(string id, string name, string street1, string street2, string city, string area, string pincode, string slack, string facebook, string twitter)
            {
                id = id;
                name = name;
                street1 = street1;
                street2 = street2;
                city = city;
                area = area;
                pincode = pincode;
                slack = slack;
                facebook = facebook;
                twitter = twitter;

            }
            public  void Register()
            {
                Developer d = new Developer();
                a1.Add(d);
            }
            public void Register(string id, string name, string street1, string street2, string city, string area, string pincode, string email, string contactNumber, string linkURL)
            {

            }
            public List<Employee> display(string newId)
            {
                if (newId == id)
                {
                    return a1;
                }
                else
                {
                    return new List<Employee>();
                }
            }
            ~Developer()
            {

            }
        }

    }

