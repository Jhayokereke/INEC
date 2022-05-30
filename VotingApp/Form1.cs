using Commons.Enums;
using Core.Contracts;
using Core.DTOs;
using Core.Services;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingApp
{
    public partial class Form1 : Form
    {
        private readonly IRegistrationService _regService;
        private Gender _gender;

        public Form1(IRegistrationService registrationService)
        {
            InitializeComponent();
            Gender_cmbox.DataSource = Enum.GetNames(typeof(Gender));
            _regService = registrationService;
        }

        private async void Enter_btn_Click(object sender, EventArgs e)
        {
            var voter = await _regService.RegisterNewVoter(new VoterRegDTO
            {
                Firstname = Firstname_txtbox.Text,
                Middlename = Middlename_txtbox.Text,
                Lastname = Lastname_txtbox.Text,
                DateOfBirth = DOB_picker.Value.ToString("dd/MM/yyyy"),
                Gender = _gender
            });


            MessageBox.Show($"{voter.Firstname + " " + voter.Lastname} with id:{voter.Id} Registered!!");
        }

        private void Gender_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _gender = Enum.Parse<Gender>(Gender_cmbox.SelectedItem.ToString());
            if ( _gender == Gender.Male)
                Passport_picbox.Image = Properties.Resources.man;
            else
                Passport_picbox.Image = Properties.Resources.woman;
        }
    }
}
