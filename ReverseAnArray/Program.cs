class  ReverseAnArray
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        

            for (int i=nums.Length-1; i>=0; i--)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",nums));
                
        }
    }
    
