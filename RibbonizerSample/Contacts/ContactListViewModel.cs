﻿namespace RibbonizerSample.Contacts
{
    using Caliburn.Micro;

    using PropertyChanged;

    [ImplementPropertyChanged]
    public class ContactListViewModel : IPageViewModel
    {
        public ContactListViewModel()
        {
            this.Contacts = new BindableCollection<ContactViewModel>
                                {
                                    new ContactViewModel
                                        {
                                            FirstName = "Gary",
                                            LastName = "Roper",
                                            Organization = "Cohesion without Bounds"
                                        },
                                    new ContactViewModel
                                        {
                                            FirstName = "Victor",
                                            LastName = "Nguyen",
                                            Organization = "Cohesion without Bounds"
                                        },
                                    new ContactViewModel
                                        {
                                            FirstName = "Chadwick",
                                            LastName = "Deluca",
                                            Organization = "Teleworm"
                                        },
                                    new ContactViewModel
                                        {
                                            FirstName = "Arthur",
                                            LastName = "Leach",
                                            Organization = "Leach Inc."
                                        },
                                    new ContactViewModel
                                        {
                                            FirstName = "Fay",
                                            LastName = "Fisk",
                                            Organization = "Teleworm"
                                        }
                                };
        }

        public IObservableCollection<ContactViewModel> Contacts { get; private set; }

        public ContactViewModel SelectedItem { get; set; }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}