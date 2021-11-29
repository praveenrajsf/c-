using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidVaccinationProject
{
    //class to get vaccination details of user
    public class VaccinationDetails
    {
        public long RegisterNumber { get; set; }
        public VaccineType VaccinationType { get; set; }
        public int VaccinationDosage { get; set; }
        public DateTime VacinationTime { get; set; }
        public VaccinationDetails(long registerNumber, int vacinationType, int vaccinationDosage, DateTime vacinationTime)
        {
            RegisterNumber = registerNumber;
            VaccinationType = (VaccineType)vacinationType;
            VaccinationDosage = vaccinationDosage;
            VacinationTime = vacinationTime;
        }
        // enum of vaccination type while login and choose option take vaccination
           public enum VaccineType
           {
               Others,
               Covaccine,
               Covishield,
           }
           public static string GetVaccination(VaccineType VaccinationType)
           {
               switch (VaccinationType)
               {
                   case VaccineType.Others:
                       return "Others";
                   case VaccineType.Covaccine:
                       return "Covaccine";
                   case VaccineType.Covishield:
                       return "Covishield";
                   default:
                       return "Invalid Data";
               }

           }
    }
    //class to get user details
    public class BenefisaryDetails
    {
        public long RegisterNumber { get; set; }
        public string UserName { get; set; }
        public long UserPhoneNumber { get; set; }
        public string UserCity { get; set; }
        public int UserAge { get; set; }
        public Gender UserGender { get; set; }
        
        public BenefisaryDetails(long registerNumber, string userName, long userPhoneNumber, string userCity, int userAge, int userGender)
        {
            RegisterNumber = registerNumber;
            UserName = userName;
            UserPhoneNumber = userPhoneNumber;
            UserCity = userCity;
            UserAge = userAge;
            UserGender = (Gender)userGender;
        }
        //Enum for getting Gender details while registration
        public enum Gender
        {
            Others,
            Male,
            Female,
        }
        public static string GetGender(Gender UserGender)
        {
            switch (UserGender)
            {
                case Gender.Others:
                    return "Others";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid Data";
            }

        }
    }
    public class BenefisaryManager
    {
         List<VaccinationDetails> vaccinationList = new List<VaccinationDetails>();
         List<BenefisaryDetails> benefisaryList = new List<BenefisaryDetails>();
        //intial resgister of some user details
        public void InitialRegisterDetails()
        {
            BenefisaryDetails benefisaryDetails1 = new BenefisaryDetails(100197, "Praveen", 8870118193, "Alangudi", 21, 1);
            BenefisaryDetails benefisaryDetails2 = new BenefisaryDetails(100198, "Raj", 8870118194, "Pudukkottai", 21, 1);
            BenefisaryDetails benefisaryDetails3 = new BenefisaryDetails(100199, "PraveenRaj", 8870118195, "Chennai", 21, 1);
            benefisaryList.Add(benefisaryDetails1);
            benefisaryList.Add(benefisaryDetails2);
            benefisaryList.Add(benefisaryDetails3);
            
        }
        //intial resgister of some user vaccination details
        public void VaccineInitialRegister()
        {
            DateTime dt1 = new DateTime(10 / 11 / 2021);
            DateTime dt2 = new DateTime(6 / 11 / 2021);
            DateTime dt3 = new DateTime(5 / 11 / 2021);
            VaccinationDetails vaccinationDetails1 = new VaccinationDetails(100197, 1, 0, dt1);
            VaccinationDetails vaccinationDetails2 = new VaccinationDetails(100198, 1, 1, dt2);
            VaccinationDetails vaccinationDetails3 = new VaccinationDetails(100199, 1, 2, dt3);
            vaccinationList.Add(vaccinationDetails1);
            vaccinationList.Add(vaccinationDetails2);
            vaccinationList.Add(vaccinationDetails3);
        }
        //Method to get user details
        public void Register()
        {
           
            Console.WriteLine("--------------------------------------------------------");
            Console.Write("Enter Name:");
            string userName = Console.ReadLine();
            //Enum
            Console.WriteLine("0.Other");
            Console.WriteLine("1.Male");
            Console.WriteLine("2.Female");
            Console.WriteLine("Enter Gender");
            string userGender1 = Console.ReadLine();
            int userGender = int.Parse(userGender1);
            Console.Write("Enter PhoneNumber:");
            String userPhoneNumber1 = Console.ReadLine();
            long userPhoneNumber = long.Parse(userPhoneNumber1);
            Console.Write("Enter Address:");
            string userCity = Console.ReadLine();
            Console.Write("Enter Age:");
            string userAge1 = Console.ReadLine();
            int userAge = int.Parse(userAge1);
            Console.Write("Enter registerNumber:");
            String registerNumber1 = Console.ReadLine();
            long registerNumber = long.Parse(registerNumber1);
            Console.WriteLine("Your Registration Number:" + registerNumber);
            BenefisaryDetails benefisary = new BenefisaryDetails(registerNumber, userName, userPhoneNumber, userCity, userAge, userGender);
            benefisaryList.Add(benefisary);
            Console.WriteLine("--------------------------------------------------------");
        }
        //login using register number.
        public void Login()
        {
            //do while string
            string chooseContiune = "";
            //get user input
            Console.Write("Enter Register Number:");
            string registerNumber1 = Console.ReadLine();
            long registerNumber = long.Parse(registerNumber1);
            foreach (BenefisaryDetails i in benefisaryList)
            {
                if (i.RegisterNumber == registerNumber)
                {
                    do
                    {
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("1.Take Vaccination");
                        Console.WriteLine("2.Vacination History");
                        Console.WriteLine("3.Next Due Date");
                        Console.WriteLine("4.Exit");
                        Console.WriteLine("--------------------------------------------------------");
                        Console.Write("Select:");
                        string chooseOption1 = Console.ReadLine();
                        int chooseOption = int.Parse(chooseOption1);
                        //Take vaccination
                        if (chooseOption == 1)
                        {
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine("1.Covaccine");
                            Console.WriteLine("2.Covishield:");
                            Console.Write("Select:");
                            string vacinationType1 = Console.ReadLine();
                            int vacinationType = int.Parse(vacinationType1);
                            Console.Write("Enter Dosage:");
                            string vaccinationDosage1 = Console.ReadLine();
                            int vaccinationDosage = int.Parse(vaccinationDosage1);
                            DateTime vacinationTime = DateTime.Now;
                            VaccinationDetails details = new VaccinationDetails(registerNumber, vacinationType, vaccinationDosage, vacinationTime);
                            vaccinationList.Add(details);
                            Console.WriteLine("--------------------------------------------------------");
                        }
                        //Vaccination history
                        else if (chooseOption == 2)
                        {
                            foreach(VaccinationDetails j in vaccinationList)
                            {
                                if (j.RegisterNumber == registerNumber)
                                {
                                    Console.WriteLine("--------------------------------------------------------");
                                    Console.WriteLine("Register Number:" + j.RegisterNumber);
                                    Console.WriteLine("Vaccination Type:" + j.VaccinationType);
                                    Console.WriteLine("Vaccination Dosage:" + j.VaccinationDosage);
                                    Console.WriteLine("Date:" + j.VacinationTime);
                                    Console.WriteLine("--------------------------------------------------------");
                                }
                              
                            }
                        }
                        //Next due date vaccination//vacination date+30days
                        else if (chooseOption == 3)
                        {
                            foreach (VaccinationDetails j in vaccinationList)
                            {
                                if (j.RegisterNumber == registerNumber)
                                {
                                    if (j.VaccinationDosage == 1)
                                    {
                                        Console.WriteLine("--------------------------------------------------------");
                                        DateTime dueDate = j.VacinationTime.AddDays(30);
                                        Console.WriteLine("Due Date:" + dueDate);
                                        Console.WriteLine("--------------------------------------------------------");
                                    }
                                    else if (j.VaccinationDosage == 2)
                                    {
                                        Console.WriteLine("--------------------------------------------------------");
                                        Console.WriteLine("You have completed vaccination course ");
                                        Console.WriteLine("Thanks for your participation in vaccination drive");
                                        Console.WriteLine("--------------------------------------------------------");
                                    }
                                }
                            }

                        }
                        Console.Write("Do you want stay login:");
                        chooseContiune = Console.ReadLine();
                        //yes to continue
                        //No to logout
                    } while (chooseContiune == "yes");
                }
            }
        }
    }
}