public class DuplicateNumbers {
    public static void main(String[] args) {
        int []arr={1,2,3,4,3,2,1,5,5};

        for(int i=0;i<=arr.length-1;i++){

            for(int j=0;j<i;j++){
                if(arr[i]==arr[j]){
                    System.out.println(arr[i]);
                }
            }
        }
    }
}
