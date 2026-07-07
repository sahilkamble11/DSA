public class PrimeNumber {

    public static void main(String[] args) {
        int num=13;
        boolean prime=false;

        for(int i =2; i * i <=num;i++){
           if(num%i==0){
            prime=false;
            System.out.println(num+" not prime");
           }
           else{
            System.out.println(num+" is  prime");
           }
        }
        
    }
    
}
