class Program {
    static void Main(string[] args) {
        int[] nums = new int[5];
        int[] nums2 = [4, 8, 12, 16];
        

        // for (int i = 0; i < 5; ++i ) {
        //     nums[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // Console.WriteLine(nums.Length);
        // for (int i = nums.Length - 1; i >= 0; --i ) {
        //     Console.Write(nums[i] + " ");
        // }

        int[,] darray = {{1, 2, 3}, {3, 4, 5}};
        int[,] test = new int[3, 4];

        int rows = darray.GetUpperBound(0) + 1;
        int col = darray.Length / rows;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < col; j++) {
                Console.Write($"{darray[i,j]}");
            }
            Console.WriteLine();
        }

        int[][] zub = new int[3][];
        
        zub[0] = new int[] {1, 2, 3};
        zub[1] = new int[] {4, 5, 6};
        zub[2] = new int[] {7, 8, 9};
    
        foreach (int[] i in zub) {
            foreach(int j in i) {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(darray.Length);
        Console.WriteLine(darray.Rank);
        Console.WriteLine(darray.GetLength(0));
    }
}