class Auditory {
    List<Student> auditory = [
        new Student {
            FirstNmae = "Ivan",
            LastName = "Ivanov",
            BirthDate = new DateTime(1997, 3, 12)
        },
        new Student {
            FirstNmae = "Olga",
            LastName = "Ivanova",
            BirthDate = new DateTime(2003, 6, 1)
        },
        new Student {
            FirstNmae = "Anna",
            LastName = "Sergeevna",
            BirthDate = new DateTime(2001, 1, 1)
        }
    ];

    public IEnumerator<Student> GetEnumerator() {
        for (int i = 0; i < auditory.Count; i++) {
            yield return auditory[i];
        }
    }
}