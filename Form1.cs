using System;
using System.Windows.Forms;
using System.Collections.Generic;
using DjurparkenWinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Runtime.InteropServices;

namespace DjurparkenWinForms
{
    public partial class Form1 : Form
    {
        private zoo Djurparken;
        private System.Windows.Forms.TextBox animalFeedTextBox;
        private System.Windows.Forms.TextBox animalPlayTextBox;


        public Form1()
        {
            InitializeComponent();
            Djurparken = new zoo(100);               
        }

       

  
        private void PrintAnimals()
        {
            string animalList = "";
            foreach (animal currentAnimal in Djurparken.GetAnimalList())
            {
                animalList += currentAnimal + "\n";
            }
            MessageBox.Show($"Lista över alla djur:\n\n{animalList}", "Djurparkens djur");
        }

        
        private void FeedAnimal(string animal)
        {
            info_output.Text = $"Du matar: {animal}";
        }
        

        
        private void PlayWithAnimal(string message)
        {
            info_output.Text = message;

        }

       
        private void ShowVisitors()
        {
            string visitorList = "Besökare:" + Environment.NewLine;

            foreach (Visitor visitor in Djurparken.GetVisitorList())
            {
                visitorList += $"{visitor}\n";
            }

            info_output.Text = visitorList;
           
        }

        
        private string GetUserInput(string prompt)
        {
            string userInput = Microsoft.VisualBasic.Interaction.InputBox(prompt, "Användarinput", "");

            return userInput;
        }
        

        // Visa info angående djurparken
        private void ShowInfoBtn_Click(object sender, EventArgs e)
        {
            
            zoo Djurparken = new zoo(100); // Skapa ett zoo objekt med biljettpriset 100 Kr
            int ticketPrice = Djurparken.GetTicketPrice(); // Hämta biljettpriset
            string OpeningHours = Djurparken.GetOpeningHours(); // Hämta öppetiderna
            
            info_output.Text = "Information angående Djurparken:" + Environment.NewLine + $"{OpeningHours}" + Environment.NewLine + $"Biljettpris: {ticketPrice} kr";
            
        }

        // Skriver ut alla djuren
        private void WriteAnimalsBtn_Click(object sender, EventArgs e)
        {
            zoo Djurparken = new zoo(100);
            List<animal> animals = Djurparken.GetAnimalList();

            string allAnimalsInfo = "";
            foreach (animal currentAnimal in animals)
            {
                allAnimalsInfo += currentAnimal + "\n";
            }
            

            info_output.Text = allAnimalsInfo;
        }

       

        
        private void PlayWithAnimalBtn_Click(object sender, EventArgs e)
        {
            
        }

        // Lägg till besökare
        private void AddVisitorBtn_Click(object sender, EventArgs e)
        {
            // Hämta värdena från användarinput
            string firstName = first_name.Text;
            string lastName = last_name.Text;

            // Försök konvertera ålder till en integer
            if (int.TryParse(age_input.Text, out int age))
            {
                // Skapa en besökare
                Visitor newVisitor = new Visitor(firstName, lastName, age);

                // Lägg till besökaren i djurparken
                Djurparken.AddVisitor(newVisitor);

                // Visa meddelande om att besökaren är registrerad
                info_output.Text = "Besökare är registrerad!";
            }
            else
            {
                // Meddela felaktig ålder
                info_output.Text = "Ogiltig ålder. Var vänlig ange ett heltal.";
            }

        }


    

        // Skriv ut besökare
        private void ShowVisitorBtn_Click(object sender, EventArgs e)
        {
           ShowVisitors();
        }


        // Avsluta programmet
        private void EndProgramBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void user_input_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void förnamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void efternamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void ålder_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void which_animal_feed_TextChanged(object sender, EventArgs e)
        {

        }

        private void which_animal_play_TextChanged(object sender, EventArgs e)
        {

        }

        private void FeedAnimalBtn_Click(object sender, EventArgs e)
        {
            
        }

        // MATA DJUREN & SKRIV UT MEDDELANDE
        private void lion_feed_Click(object sender, EventArgs e)
        {          
            FeedAnimal("Simba" + Environment.NewLine + "Han tuggar glatt i sig kött och är nöjd..");     
        }

        private void lioncub_feed_Click(object sender, EventArgs e)
        {
            FeedAnimal("Akira" + Environment.NewLine + "Han springer omkring och smaskar på lite köttbullar..");
        }

        private void wolf_feed_Click(object sender, EventArgs e)
        {

            FeedAnimal("Ghost" + Environment.NewLine + "Han ylar och gottar sig med lite älgkött..");
        }

        private void beaver_feed_Click(object sender, EventArgs e)
        {
            FeedAnimal("Lars" + Environment.NewLine + "Han simmar omkring och plaskar med sin svans medans han tuggar i sig lite god bark..");
        }
        /// -----------------------------------------------------------------



        // LEK MED DJUREN
        private void lion_play_Click(object sender, EventArgs e)
        {
            PlayWithAnimal("En djurskötare kastar bollen till Simba.." + Environment.NewLine + "Han springer glatt och jagar efter bollen..");
        }

        private void lioncub_play_Click(object sender, EventArgs e)
        {
            PlayWithAnimal("En djurskötare klappar på Akira.." + Environment.NewLine + "Han lägger sig på mage och spinner..");
        }

        private void wolf_play_Click(object sender, EventArgs e)
        {
            PlayWithAnimal("En djurskötare jagar efter Ghost.." + Environment.NewLine + "Han springer, hoppar omkring och börjar istället jaga efter djurskötaren..");
        }

        private void beaver_play_Click(object sender, EventArgs e)
        {
            PlayWithAnimal("En djurskötare kastar en pinne till Lars.." + Environment.NewLine + "Lars simmar omkring och kastar runt pinnen i vattnet..");
        }

       
       
    }
}
