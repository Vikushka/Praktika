using System.Windows;
using Praktika.Admin;
using Praktika.Cotrudnik;
namespace Praktika
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // user- администратор
        private User user = new User("admin", "123");

        // chel= сотрудник

        private Chel chel = new Chel("cotrudnik", "456");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (user.UserName == tbUserName.Text && user.Password == pbPassword.Text)
            {
                Admin_Window admin_Window = new Admin_Window();
                admin_Window.Show();



            }
            else

            {
                MessageBox.Show("Неверный логин или пароль");
            }


            if (chel.UserName == tbUserName.Text && chel.Password == pbPassword.Text)
            {
                Chel_Window chel_window = new Chel_Window();
                chel_window.Show();
            }
            else

            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }



    }
}    

