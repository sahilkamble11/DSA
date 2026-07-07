public class Palindrome {

    public static void main(String[] args) {
        
    String str1="madam";
    //String str2="madam";
    String str3="";

    for(int i=str1.length()-1 ; i>=0 ; i--){
        str3=str3 + str1.charAt(i);
    }
    if(str1.equals(str3)){
        System.out.println("palindrome");
    }
    else{
        System.out.println("Not Palindrome");
    }
    }
   
}
