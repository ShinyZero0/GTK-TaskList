using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace GTKPlayGround
{
    class NewTaskDialog : Window
    {
        public NewTaskDialog() : this(new Builder("NewTaskDialog.glade")) { }

        private NewTaskDialog(Builder builder) : base(builder.GetRawOwnedObject("NewTaskDialog"))
        {
            builder.Autoconnect(this);
        }
    }
}
