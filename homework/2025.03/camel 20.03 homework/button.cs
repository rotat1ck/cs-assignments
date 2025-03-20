static class Button {
    public delegate void ButtonClick();
    static public event ButtonClick? clicked;

    static public void Click() {
        if (clicked != null) {
            clicked();
        }
    }
}