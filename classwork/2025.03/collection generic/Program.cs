using System.Collections;
using System.Collections.Generic;

class Code {
    static void Main() {
        // ArrayList arrayList = new();
        // arrayList.Add(10);
        // try {
        //     short a = (short) arrayList[0];
        // } catch (Exception ex) {
        //     Console.WriteLine(ex.Message);
        // }

        // object obj = 45;
        // Console.WriteLine("Boxing: " + obj);

        // int b = (int) obj;
        // Console.WriteLine("Unboxing: " + b);

        // List<int> list = [1, 2, 3];
        // list.Add(1);

        ValueTypePerfTest();
    }

    static void ValueTypePerfTest() {
        const int count = 10000000;

        using(new OperationTimer("List")) {
            List<int> list = new List<int>(count);
            for (int i = 0; i < count; ++i) {
                list.Add(i);
                int x = list[i];
            }
            list = null;
        }

        using(new OperationTimer("ArrayList")) {
            ArrayList list = new ArrayList(count);
            for (int i = 0; i < count; ++i) {
                list.Add(i);
                int x = (int)list[i];
            }
            list = null;
        }
    }
}