
class Program{
    public static void Main(){
        Fordon a = new Fordon();
        a.setTillverkare("BMW");
        a.setModell("a8");
        a.setVikt(700);
        a.setÅrsmodell(2022);

     Fordon b = new Fordon();
        b.setTillverkare("Ford");
        b.setModell("s8");
        b.setVikt(500);
        b.setÅrsmodell(2020);

        Console.WriteLine(a.getTillverkare());
        Console.WriteLine(a.getModell());
        Console.WriteLine(a.getVikt());
        Console.WriteLine(a.getÅrsmodell());

        Console.WriteLine(b.getTillverkare());
        Console.WriteLine(b.getModell());
        Console.WriteLine(b.getVikt());
        Console.WriteLine(b.getÅrsmodell());
    }
    
}


