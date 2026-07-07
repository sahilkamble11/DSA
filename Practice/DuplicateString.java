// public class DuplicateString {
//     public static void main(String[] args) {
//         String str="programming";

//         for (int i=0;i<=str.length()-1;i++){
//             boolean visited=false;
//             for(int j=1;j<i;j++){
//                 if(str.charAt(i)==str.charAt(j)){
//                     visited=true;
//                     break;
//                 }

//                 if(visited){
//                     continue;
//                 }
//             }
//             for(int k=i;k<i;k++){
//                 if(str.charAt(i)==str.charAt(k)){
//                     System.out.println(k);
//                 }
//             }
//         }
//     }
// }

public class DuplicateString {

    public static void main(String[] args) {

        String str = "programming";

        for (int i = 0; i < str.length(); i++) {

            boolean visited = false;

            // Check if character already appeared
            for (int j = 0; j < i; j++) {

                if (str.charAt(i) == str.charAt(j)) {
                    visited = true;
                    break;
                }
            }

            if (visited) {
                continue;
            }

            // Find duplicate ahead
            for (int k = i + 1; k < str.length(); k++) {

                if (str.charAt(i) == str.charAt(k)) {
                    System.out.println(str.charAt(i));
                    break;
                }
            }
        }
    }
}