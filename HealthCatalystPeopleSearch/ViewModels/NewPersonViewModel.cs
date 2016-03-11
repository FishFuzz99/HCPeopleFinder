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
using System.Windows.Input;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace HealthCatalystPeopleSearch.ViewModels
{
    public class NewPersonViewModel : Screen
    {
        private IPeopleRepository _repository;

        public NewPersonViewModel(IPeopleRepository repository)
        {
            _repository = repository;
        }

        private string _message;
        public string message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value; NotifyOfPropertyChange(() => message);
            }
        }

        private string _firstName;
        public string firstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value; NotifyOfPropertyChange(() => firstName);
            }
        }

        private string _lastName;
        public string lastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value; NotifyOfPropertyChange(() => lastName);
            }
        }

        private int? _age;
        public int? age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value; NotifyOfPropertyChange(() => age);
            }
        }

        private string _address;
        public string address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value; NotifyOfPropertyChange(() => address);
            }
        }

        private string _interests;
        public string interests
        {
            get
            {
                return _interests;
            }
            set
            {
                _interests = value; NotifyOfPropertyChange(() => interests);
            }
        }

        private Image _image;
        public Image image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value; NotifyOfPropertyChange(() => image);
            }
        }

        private void selectFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {

            }
        }

        public void Cancel()
        {
            IoC.Get<MainViewModel>().People();
        }

        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public void Browse(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a picture";
            openFileDialog.Filter = "All supported graphics|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == true)
            {
                image = new Bitmap(openFileDialog.FileName);
            }
        }

        public void AddNewPerson()
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                message = "First and Last name are required.";
            }
            else
            {
                var newPerson = new Person
                {
                    firstName = _firstName,
                    lastName = _lastName,
                    age = _age,
                    address = _address,
                    interests = _interests
                };

                if (image != null)
                {
                    newPerson.image = image;
                }

                try
                {
                    _repository.addPersonAsync(newPerson);
                }
                catch (ApplicationException ae)
                {
                    message = ae.Message;
                }
                

                firstName = "";
                lastName = "";
                age = null;
                interests = "";
                address = "";
                message = "";
                image = null;
            }

        }

    }
}