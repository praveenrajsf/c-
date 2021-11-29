using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidVaccinationProject
{
     class MainMenu
    {
        static void Main(string[] args)
        {
           //creating object for Class BenfisaryManager
            BenefisaryManager benefisaryManager = new BenefisaryManager();
            //intial resgister of some user details
            benefisaryManager.InitialRegisterDetails();
            //intial resgister of some user vaccination details
            benefisaryManager.VaccineInitialRegister();
            string chooseContiune = "";
            do
            {
                Console.WriteLine("1.Login");
                Console.WriteLine("2.Register");
                Console.Write("Select:");
                string chooseOption1 = Console.ReadLine();
                int chooseOption = int.Parse(chooseOption1);
                switch (chooseOption)
                {
                    case 1:
                        //Login
                        benefisaryManager.Login();
                        break;
                    case 2:
                        //New Registration
                        benefisaryManager.Register();
                        break;
                 }
                //user option
                Console.WriteLine("Do You Want Continue");
                chooseContiune = Console.ReadLine();
                //yes to continue
                //No to logout
            } while (chooseContiune == "yes");
        }
        
    }
}
