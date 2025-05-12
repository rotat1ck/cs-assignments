class Facade {
    SubSystem1 subSystem1 = new();
    SubSystem2 subSystem2 = new();
    SubSystem3 subSystem3 = new();
    SubSystem4 subSystem4 = new();

    public void Operation1_2() {
        subSystem1.Operation1();
        subSystem2.Operation2();
    }

    public void Operation3_4() {
        subSystem3.Operation3();
        subSystem4.Operation4();
    }
}