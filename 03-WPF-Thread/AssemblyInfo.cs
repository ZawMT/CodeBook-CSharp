using System.Windows;

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
                                     //(used if a resource is not found in the page,
                                     // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
                                              //(used if a resource is not found in the page,
                                              // app, or any theme specific resource dictionaries)
)]

// CodeBookNote#0
// This project is done in the purpose of achieving these:
// 1: Just try creating UI elements in a WPF application
// 2: Try to do something in the thread and show it to the UI

// CodeBookNote#1
// First thing to note: 
// A button added to the form will stay fixed in a location. So when a form is resized the location of the button might turn out to be in appropriate.
// In WPF, this can be avoided using different layouts. In this project, grid layouts are used.
// Refer MainWindow.xaml (source code) where Grid layouts are defined. 0.1* means 10 percent, and * means the rest / remaining.
// After defining the layout, each control can be assigned to grid which layout is translated by Row/Column => E.g. Grid.Column = "0"
// After setting the grids, the button will stay at a relatively nice location even while the form is being resized.

// CodeBookNote#2
// RenderTransformOrigin="0.5,.5" is to set the pivot point of the transform (rotation) at the center of the image
// Take note about these: Image / RenderTransform / RotateTransform

// CodeBookNote#3
// lblAngle is referring to the Angle of RotateTransform so no code will be needed to reflect the change in the UI when the image is being rotated.
// It is used 'Binding' mechanism