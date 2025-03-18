using System.Linq;
using System.Reflection.Metadata;
class Code {
    static void Main() {
        // Console.Write("Enter sentecnce: ");
        // string? str = Console.ReadLine();

        // Console.WriteLine($"Word count: {str.NumberWords()}");

        int[] arr = [5, 34, 67, 12, 94, 42];
        // IEnumerable<int> query = from i in arr where i % 2 == 0 orderby i descending select i;

        // Console.WriteLine("Before update:");
        // foreach (int item in query) {
        //     Console.Write($"{item} \t");
        // }
        // arr[0] = 25;
        // Console.WriteLine("\nAfter update:");
        // foreach (int item in query) {
        //     Console.Write($"{item} \t");
        // }


        // IEnumerable<IGrouping<int, int>> query = from i in arr group i by i % 10 
        //                                         into res where res.Count() > 1 select res;

        // Console.WriteLine("Groups:");
        // foreach (IGrouping<int, int> item in query) {
        //     Console.WriteLine($"Group {item.Key}: {string.Join(" ", item)}");
        // }


        // string[] poem = {"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 
        //             "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat;", 
        //             "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur,",
        //             "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
        // };

        // IEnumerable<string> query2 = from p in poem
        //                             let words = p.Split(' ', ';', ',')
        //                             from w in words
        //                             where w.Count() > 7
        //                             select w;

        // Console.WriteLine("Words with more than 7 letters:");
        // foreach (string item in query2) {
        //     Console.WriteLine(item);
        // }

        List<Group> groups = new() {
            new Group {
                Id = 1,
                Name = "Group 1",
            }, new Group {
                Id = 2,
                Name = "Group 2",
            }
        };

        List<Student> students = new() {
            new Student {
                FirstName = "Ivan",
                LastName = "Ivanov",
                GroupId = 1
            }, new Student {
                FirstName = "Petr",
                LastName = "Petrov",
                GroupId = 2
            }, new Student {
                FirstName = "Anna",
                LastName = "Ivanova",
                GroupId = 1
            }, new Student {
                FirstName = "Vova",
                LastName = "Sidorov",
                GroupId = 2
            }
        };

        // return IEnumerable student array
        IEnumerable<Student> query3 = from g in groups 
                                    join st in students on g.Id equals st.GroupId
                                    into res
                                    from s in res
                                    select s;

        Console.WriteLine("Students:");
        foreach (Student item in query3) {
            Console.WriteLine($"{item.FirstName}, {item.LastName}, {groups.First(g => g.Id == item.GroupId).Name}");
        }

        // returns anon type
        var query4 = from g in groups
                    join st in students on g.Id equals st.GroupId
                    select new {
                        FirstName = st.FirstName,
                        LastName = st.LastName,
                        GroupName = g.Name
                    };

        Console.WriteLine("Students:");
        foreach (var item in query4) {
            Console.WriteLine($"{item.FirstName}, {item.LastName}, {item.GroupName}");
        }   
    }
}