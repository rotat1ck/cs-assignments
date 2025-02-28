using System.Collections;

class Auditory : IEnumerable {
    Student[] students = [
        new Student {
            FirstName = "Leeky",
            LastName = "Suya",
            BirthDate = new DateTime(2004, 12, 27),
            StudentCard = new StudentCard {
                Number = 69,
                Series = "72ACD125"
            }
        },
        new Student {
            FirstName = "Luna",
            LastName = "Kurree",
            BirthDate = new DateTime(2004, 02, 15),
            StudentCard = new StudentCard {
                Number = 42,
                Series = "61EFH537"
            }
        },
    ];
    public void Sort() {
        Array.Sort(students);
    }

    public void Sort(IComparer comparer) {
        Array.Sort(students, comparer);
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return students.GetEnumerator();
    }
}