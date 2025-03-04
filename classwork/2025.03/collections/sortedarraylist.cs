using System.Collections;

class SortedArrayList : ArrayList {
    public void AddSorted(object item) {
        int position = BinarySearch(item);
        if (position < 0) {
            position = ~position;
        }
        Insert(position, item);
    }

    public void ModifySorted(object item, )
}