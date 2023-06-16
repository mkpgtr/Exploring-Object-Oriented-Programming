namespace Shapes{

    public class Shape {

        public virtual double calculateArea(){
            return 0;
        }
    }

    public class Square :Shape {

        public double side{get;set;}
        public override double calculateArea(){
            return side * side;
        }
    }

    public class Circle : Shape {
        public double radius;

        public override double calculateArea(){
            return Math.PI * radius * radius;
        }
    }

    public class Triangle : Shape {
        public double height{get;set;}
        public double Width{get;set;}

        public override double calculateArea(){
            return 0.5 * height * Width;
        }
    }
}