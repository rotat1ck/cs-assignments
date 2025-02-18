class Student {
    string firstName;
    string lastName;
    string groupName;
    int age;
    int[][] grades;

    public Student(string firstName, string lastName, string groupName, int age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.groupName = groupName;
        this.age = age;
        grades = [
            [],
            [],
            []
        ];
    }

    public void SetGrade(Subjects subject, int grade) {
        switch (subject) {
            case Subjects.Programming:
                grades[0] = [.. grades[0], grade];
                break;
            case Subjects.Administration:
                grades[1] = [.. grades[1], grade];
                break;
            case Subjects.Design:
                grades[2] = [.. grades[2], grade];
                break;
        }
    }

    public int[] getGrades(Subjects subject) {
        switch (subject) {
            case Subjects.Programming:
                return grades[0];
            case Subjects.Administration:
                return grades[1];
            case Subjects.Design:
                return grades[2];
            default:
                return [];
        }
    }
}