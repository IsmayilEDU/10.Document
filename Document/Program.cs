using Document.DocumentClasses;
using Document.Models;
using Document.Models.AbsractClasses;
using MyLibrary;

namespace Document
{


    internal class Program
    {
        //  Create Document 
        public static DOCUMENT CreateDocumentInSelectOption(int SelectOption)
        {
            //  Create Document reference
            DOCUMENT? document = null;

            //  Create Dcoument in SelectOption
            switch (SelectOption)
            {
                //  Create Basic Document
                case 0:
                    document = new DOCUMENT();
                    break;

                //  Create Pro Document
                case 1:
                    document = new ProDocument();
                    break;

                //  Create Expert Document
                case 2:
                    document = new ExpertDocument();
                    break;
            }

            return document!;
        }

        static void Main(string[] args)
        {
            //  Options for Main Menu
            List<string> OptionsOfMainMenu = new List<string>() { "Basic", "Pro", "Expert", "Exit" };

            //  Options for Documents
            List<string> OptionsOfDocumentMenu = new List<string>() { "Open", "Edit", "Save", "Exit" };

            //  Main Menu
            do
            {

                //  Main Menu
                int SelectOptionOfMainMenu = MyMenu.createMenu("Please select option from Main Menu:", OptionsOfMainMenu);

                //  Exit From Main Menu
                if (SelectOptionOfMainMenu == 3)
                {
                    Console.Clear();
                    break;
                }

                //  Document Menu
                else
                {
                    DOCUMENT document = Program.CreateDocumentInSelectOption(SelectOptionOfMainMenu);

                    try
                    {
                        do
                        {
                            int SelectOptionOfDocumentMenu = MyMenu.createMenu("Please select functionality of document:", OptionsOfDocumentMenu);
                            switch (SelectOptionOfDocumentMenu)
                            {
                                //  Open function of document
                                case 0:
                                    MyConsole.ShowDescriptionInGreen(document.OpenDocument());
                                    break;

                                //  Open function of document
                                case 1:
                                    MyConsole.ShowDescriptionInGreen(document.EditDocument());
                                    break;

                                //  Open function of document
                                case 2:
                                    MyConsole.ShowDescriptionInGreen(document.SaveDocument());
                                    break;
                                
                                //  Exit From Document Menu
                                case 3:
                                    throw new MyException("You logget out Document Menu");
                                
                            }
                        } while (true);

                    }
                    catch (MyException ex) { MyConsole.ShowDescriptionInRed(ex.Message); }
                }

            } while (true);
        }
    }
}