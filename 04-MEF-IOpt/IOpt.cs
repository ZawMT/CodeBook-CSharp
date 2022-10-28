using System;

/*
 * This is the first project which comprises a series of four: together they will describe MEF (Managed Extensibility Framework).
 * Use case is like this: 
 * There is an application which comprises of the components / layers below:
 * 1: UI for the user to use the application
 * 2: Controller or ViewModel layer which manipulates the data to be presentable in UI
 * 3: DB Access layer which will be directly talking with the DB
 * For the third layer we might be talking to MS SQL, Oracle or Text-based data system. The choice is to be made by the customer / the conditions / etc.
 * In such scenario, there can be different DLLs (or sets of DLLs) each of which can talke to a particular DB. 
 * For the application to be able to pick the corresponding DLLs (or sets of DLL), MEF is a way to go.
 * 
 * This project will define an interface
 * Second project of this series, 04-MEF-Opt1, is an optoin one of the available options 
 * Third project 04-MEF-Opt2 is another option. The available options can be many, but two is good enough to demonstrate.
 * Finally, 04-MEF-SampleConsumer is the consumer project which will be using the Opt1 or Opt2 as set up.
 */

namespace _04_MEF_Opt
{
    public interface IOpt
    {
        void OptFunction();
    }
}
