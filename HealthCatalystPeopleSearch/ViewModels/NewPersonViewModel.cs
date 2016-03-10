using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using HealthCatalystPeopleSearch.Models;
using Microsoft.Win32;
using System.Windows;
using System.IO;

namespace HealthCatalystPeopleSearch.ViewModels
{
    public class NewPersonViewModel : Screen
    {
        private IPeopleRepository _repository;

        public NewPersonViewModel(IPeopleRepository repository)
        {
            _repository = repository;
        }

        public Person newPerson;


        public async void AddPerson()
        {
            await _repository.addPersonAsync(newPerson);
        }

        private void selectFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == true)
            {

            }
        }
    }
}