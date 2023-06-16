namespace ShapeInterface {

    public interface ShapeAcrobat{

    double calculateArea();
    double calculatePerimeter();

    
}


public class Rectangle : ShapeAcrobat {
    public double length {get;set;}
    public double width {get;set;}
    public double calculateArea(){
        return 2 * (length + width);
    }

    public double calculatePerimeter(){

        return 2 * (length + width);
    }
}
}