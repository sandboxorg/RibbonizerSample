RibbonizerSample
================

## Overview
The purpose of this repository is to show a way how one can implement a ribbon menu with loose coupling and good separation of concern, even for applications with complex view model trees.

## Code Organization
This sample is currently split into three projects:
* Ribbonizer: Contains logic for active view model tracking, ribbon definition gathering, view instanciation and command wiring. Basically all the stuff that would go into a reusable library.
* RibbonizerSamle: Contains the actual sample application, with a ribbon, two pages, and some commands.
* Ribbonizer.Wrappers.Microsoft: Contains wrapper code related to [The Microsoft Ribbon for Windows Presentation Foundation] (http://msdn.microsoft.com/en-us/library/ff799534%28v=vs.110%29.aspx). You need to roll your own wrapper if you want to use Fluent, Infragistics, Telerik, or any other Ribbon Views implementation.

## Pointers
* The CreateContactCommand and the CreateEmailCommand are examples of commands which are shown and wired at the same time
* The DeleteContactCommand is only instanciated when a contact is actually selected, however, its button is shown as soon as the user navigates to the contacts page
* The DeleteEmailCommand shows how one can handle multi-selection

### Note: Property Changed Notifications

Most view models of this sample application do not implement [INotifyPropertyChanged](http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged.aspx). The excellent [NotifyPropertyChanged.Fody](https://raw.github.com/Fody/PropertyChanged) is automatically weaving this into the assembly.
