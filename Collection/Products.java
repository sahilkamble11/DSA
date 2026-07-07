public class Products{
    
        int id;
        String name;
        float price;
        int quantity;

        public Products(int id, String name, float price, int quantity) {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
    

    public static void main(String[] args) {
        
       Products flower1 = new Products(1,"Rose", 40, 3);
       Products flower2 = new Products(2, "Lily", 30, 3);

       System.out.println("Id="+flower1.id+" "+"Name="+flower1.name+" "+"price="+flower1.price+" "+"quantity="+flower1.quantity);
       System.out.println("Id="+flower2.id+" "+"Name="+flower2.name+" "+"price="+flower2.price+" "+"quantity="+flower2.quantity);
    }
    
}