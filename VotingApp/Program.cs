using Core.Persistence;
using Core.Services;
using Core;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Contracts;

namespace VotingApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Database database = new Database();
            Application.Run(new Form1(new RegistrationService(new VoterRepository(database), new CandidateRepository(database))));
        }
    }
}
