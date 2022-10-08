class program{
    static void Main(string[] args){
        var p1 = new Personal("Homero","Sinpson");
        var nacimiento =  new Fecha(12,5,1995);
        p1.setEdad(nacimiento);

        var p2 = new Personal("Marge", "Simpson");
        var nac = new DateTime(1954,3,19);
        p2.setEdad(nac);

        var var3 = new Personal("Bart", "Simpson");
        var3.setEdad(10);

        Console.WriteLine(p1.getTexto());
        Console.WriteLine(p2.getTexto());
        Console.WriteLine(var3.getTexto());
    }
}
