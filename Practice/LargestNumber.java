
import java.util.*;

public class LargestNumber {
    public static void main(String[] args) {

        int []arr={66,11,22,33,44};

        Arrays.sort(arr);
        
        for (int i : arr) {
            System.out.println(i);
        }
        System.out.println("Largest element: "+ arr[arr.length-1]);

    }    
}
