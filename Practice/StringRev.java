public class StringRev{
    public static void main(String[] args) {
       
        String original="Sahil";
        String rev="";
        String reversed=new StringBuilder(original).reverse().toString();

        for(int i=original.length()-1; i>=0 ; i--)
        {
            rev = rev + original.charAt(i);
        }



        System.out.println("Original= "+ original);
        System.out.println("Rev= "+ rev);
        System.out.println(reversed);
    }
}