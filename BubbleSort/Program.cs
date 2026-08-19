
int [] arr={6,3,5,4,1,2};

for(int i = 0 ; i < arr.Length - 1; i++)
{
    for(int j = 0 ; j < arr.Length - 1 - i ; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            int temp=arr[j];
            arr[j]=arr[j+1];
            arr[j+1]=temp; 
        } 
    }
}

 foreach(int x in arr)
        {
            Console.Write("  "+x);
        }



    



