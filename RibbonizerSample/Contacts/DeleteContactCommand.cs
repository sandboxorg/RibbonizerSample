﻿namespace RibbonizerSample.Contacts
{
    using System.Collections.Generic;
    using System.Windows;

    using Caliburn.Micro;

    using Ribbonizer.Results;
    using Ribbonizer.Ribbon.Tools.Button;

    internal class DeleteContactCommand : IRibbonButtonToolCommand
    {
        private readonly ContactViewModel viewModel;

        public DeleteContactCommand(ContactViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public bool CanExecute
        {
            get { return true; }
        }

        public IEnumerable<IResult> Execute()
        {
            yield return new AnonymousResult(() => MessageBox.Show(string.Format("deleting '{0} {1}'", this.viewModel.FirstName, this.viewModel.LastName)));
        }
    }
}