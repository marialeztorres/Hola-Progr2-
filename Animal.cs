using System;
namespace Animales
{
    class Perro
    {            
        private string nombre, raza, alimento, color;
        private  int edad;
                             
    public Perro(string nombre, string raza, string color, string alimento, int edad){  
        setNombre(nombre);
        setRaza(raza);
        setColor(color);
        setAlimento(alimento);
        setEdad(edad);}

    public void setNombre(string n) {nombre = n;}
    public void setRaza(string r) {raza = r;}
    public void setColor(string c) {color = c;}
    public void setAlimento(string a) {alimento = a;}
    public void setEdad(int x) {edad = x;}

    public string getNombre(){ return nombre; }
    public string getRaza(){ return raza; }
    public string getColor() {return color; }
    public string getAlimento() {return alimento; }
    public int getEdad(){ return edad; }

    public void mostrarperro(){
        Console.Write("\nNombre del perro: "+getNombre() + "\nraza: "+getRaza() + "\nColor: "+getColor() + 
        "\nTipo de Alimento que consume: "+ getAlimento() + "\nEdad: "+ getEdad()); 
     }
}
public class animales {
    static void Main() {
        string nombre, raza, color, alimento;
        int edad;
               /*Solicitar datos*/
        Console.Write("Ingrese el nombre de su mascota: ");   
        nombre = Console.ReadLine(); 
        Console.Write("Indique el raza de su mascota: ");
        raza = Console.ReadLine();
        Console.Write("Indique el color de un mascota: ");
        color = Console.ReadLine();
        Console.Write("Describa que tipo de alimento consume su mascota: ");
        alimento = Console.ReadLine();
        Console.Write("Indique la edad de su mascota: ");
        edad = int.Parse(Console.ReadLine());   /*ReadLine(es un metodo), console(es una clase), Parse(es un metodo),int32(es una clase) */

        Perro p;
        p = new Perro(nombre, raza, color, alimento, edad);
        p.mostrarperro();

        Console.ReadKey();
    }

}
}
 
