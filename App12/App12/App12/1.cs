using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App12
{
    public class _1 : ContentPage
    {

        public _1()
        {
            Label label1 = new Label()
            {
                HorizontalOptions = LayoutOptions.Center,
                Text = "Вы точно решили выйти?",
                TextColor = Color.Red
            };

            Button button1 = new Button()
            {
                Text = "Выход"
            };

            button1.Clicked += new EventHandler(Exit_Click);

            Content = new StackLayout
            {
                Children = { label1, button1 }
            };
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}