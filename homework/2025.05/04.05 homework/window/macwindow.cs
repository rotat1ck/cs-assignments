class MacWindow : Window {
    public override void Draw() {
        MacWindowImp imp = new();
        imp.DevDrawButton();
        imp.DevDrawForm();
    }
}