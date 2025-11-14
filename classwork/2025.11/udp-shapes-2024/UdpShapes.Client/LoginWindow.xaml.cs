namespace UdpShapes.Client;

public partial class LoginWindow : Window {
    public LoginWindow () {
        InitializeComponent ();
    }

    private void ConnectButton_Click (object sender, RoutedEventArgs e) {
        try {
            LoginVM vm = (LoginVM) this.DataContext;
            if (string.IsNullOrWhiteSpace (vm.Name))
                throw new InvalidOperationException ("Введите имя");
            if (vm.NamedColor is null)
                throw new InvalidOperationException ("Выберите цвет");
            if (vm.Shape is null)
                throw new InvalidOperationException ("Выберите фигуру");


            Player player = new Player (vm.Name, vm.NamedColor, vm.Shape);

            this.Hide ();
            MainWindow mainWindow = new MainWindow (player);
            mainWindow.ShowDialog ();
            Application.Current.Shutdown ();
        }
        catch (Exception ex) {
            MessageBox.Show (ex.Message);
        }
    }
}
