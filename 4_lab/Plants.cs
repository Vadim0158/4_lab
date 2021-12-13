using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_lab
{
    public class Plants
    {
        public static Random rnd = new Random();
        public virtual String GetInfo()
        {
            return "Растение";
        }
    }

    //кустарник
    public enum Flower { есть, нет }; // цветок
    public class Shrub : Plants
    {
         public Flower flower = Flower.есть;
         public int BranchesCount = 0; // количество веток
        public override String GetInfo()
        {
            var str = "Азалия";
            str += String.Format("\nКол-во веток: {0}", this.BranchesCount);
            str += String.Format("\nНаличие цветов: {0}", this.flower);
            return str;
        }
        public static Shrub Generate()
        {
            
            return new Shrub
            {
                BranchesCount = rnd.Next() % 100,
                flower = (Flower)rnd.Next(2) // наличие листика true или false
            };
        }
    }

    //дерево
    public enum WoodType { хвойное, листовое };
    public class Tree : Plants
    {
        public double Height = 0; // высота
        public WoodType type = WoodType.листовое; // хвойное или листовое
        public double Radius = 0; //радиус
        public override String GetInfo()
        {
            var str = "Дерево";
            str += String.Format("\nВысота: {0}", this.Height);
            str += String.Format("\nТип: {0}", this.type);
            str += String.Format("\nРадиус: {0}", this.Radius);
            return str;
        }
      
        public static Tree Generate()
        {

            return new Tree
            {
                Height = rnd.Next() % 100,
                type = (WoodType)rnd.Next(2),// наличие листика true или false
                Radius = rnd.Next() % 100
            };
        }
    }

    //цветы
    public enum Color { красный, голубй, розовый, желтый };
    public enum Type { пестики, тычинки };
    public class Flowers : Plants
    {
        public int PetalsCount = 0; // лепестки
        public Color ColorFlower = Color.желтый; // цвет
        public Type type = Type.тычинки; //пестики тычинки 
            public override String GetInfo()
            {
            var str = "Цветок";
            str += String.Format("\nЛепестков: {0}", this.PetalsCount);
            str += String.Format("\nЦвет: {0}", this.ColorFlower);
            str += String.Format("\nТип: {0}", this.type);
            return str;
            }
        public static Flowers Generate()
        {

            return new Flowers
            {
                PetalsCount = rnd.Next() % 100,
                ColorFlower = (Color)rnd.Next(2),
                type = (Type)rnd.Next(2)
            };
        }
    }
}