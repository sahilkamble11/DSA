
public class l {

    // public static void main(String[] args) {
        
    // int []arr={11,22,44,66,77,33};

    // Arrays.sort(arr);
    
    // // for (int i : arr) {
    // //     System.out.print(i+",");
    // // }
    // // System.out.println();

    // System.out.println("Largest Element: "+ arr[arr.length-1]);
    // }

    public static void main(String[] args) {
        int []arr={11,22,44,66,77,33};
        int largest=arr[0];

        for(int i=1;i<arr.length;i++){
            if(largest<arr[i]){
                largest=arr[i];
            }
        }

        System.out.println("Largest element: "+ largest);
    }
    
}
