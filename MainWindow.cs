using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace GTKPlayGround
{
    class MainWindow : Window
    {
        [UI] private Button buttonCreate;
        [UI] private Button buttonEdit;
        [UI] private Button buttonRemove;

        public MainWindow() : this(new Builder("MainWindow.glade")) { }

        private MainWindow(Builder builder) : base(builder.GetRawOwnedObject("MainWindow"))
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            buttonCreate.Clicked += ButtonCreate_Clicked;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        private void ButtonCreate_Clicked(object sender, EventArgs a)
        {
            var NewTaskWin = new NewTaskDialog();
            NewTaskWin.Show();
        }
    }
}
