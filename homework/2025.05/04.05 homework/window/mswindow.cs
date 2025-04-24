class MSWindow : Window {
    public override void Draw() {
        MSWindowImp imp = new();
        imp.DevDrawButton();
        imp.DevDrawForm();
    }
}