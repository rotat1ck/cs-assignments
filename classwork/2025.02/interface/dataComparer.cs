using System.Collections;

class DataComparer : IComparer {
    public int Compare(object x, object y) {
        if (x is Student && y is Student) {
            return DateTime.Compare((x as Student).BirthDate,
                (y as Student).BirthDate);
        }
        throw new NotImplementedException();
    }
}