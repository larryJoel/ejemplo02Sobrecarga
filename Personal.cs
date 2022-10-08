class Personal{
    string nombre;
    string apellido;
    int edad;
    public Personal(string n, string a){
        nombre = n;
        apellido=a;
    }
    public void setEdad(DateTime nacimiento){
        var hoy = DateTime.Now;
        edad= hoy.Year - nacimiento.Year;
    }
    public void setEdad(Fecha f){
        var hoy = DateTime.Now;
        edad = hoy.Year - f.anio;
    }

    public void setEdad( int e){
        edad = e;
    }

    public string getTexto()=> $"{apellido}, {nombre} edad: {edad}";
}