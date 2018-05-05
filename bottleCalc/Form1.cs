using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bottleCalc
{
    public class Sphere
    {
        public double rad;
        public double volume;
        public Sphere(double rad)
        {
            this.rad = rad;
            volume = (4.0 / 3) * (Math.PI * Math.Pow(rad, 3));
            Console.WriteLine(volume);
        }
    }

    public class Cylinder
    {
        public double height;
        public double rad;
        public double volume;
        public Cylinder(double height, double rad)
        {
            this.height = height;
            this.rad = rad;
            volume = Math.PI * Math.Pow(rad, 2.0) * height;
            Console.WriteLine(volume);
        }
    }

    public class Frustum
    {
        public double rad1; // big
        public double rad2; // small
        public double height;
        public double slant;
        public double volume;
        public Frustum(double rad1, double rad2, double height)
        {
            this.rad1 = rad1;
            this.rad2 = rad2;
            this.height = height;
            slant = Math.Sqrt(Math.Pow(height, 2.0) + Math.Pow(rad1 - rad2, 2.0));
            volume = (Math.PI * height) / 3.0 * (Math.Pow(rad1, 2) + (rad1 * rad2) + (Math.Pow(rad2, 2.0)));
            Console.WriteLine(volume);
        }
    }

    public class SphericalCap
    {
        public double rad;
        public double height;
        public double volume;
        public SphericalCap(double rad, double height)
        {
            this.rad = rad;
            this.height = height;
            volume = (Math.PI * height) / 6.0 * ((3.0 * Math.Pow(rad,2.0) + Math.Pow(height,2.0)));
            Console.WriteLine(volume);
        }
    }

    public class Cone
    {
        public double rad;
        public double height;
        public double volume;
        public Cone(double rad, double height)
        {
            this.rad = rad;
            this.height = height;
            volume = (Math.PI * Math.Pow(rad, 2)) / 3.0;
            Console.WriteLine(volume);
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //pos
            Frustum frust1 = new Frustum(5.23, 3, 3);
            Sphere sphere1 = new Sphere(4.25);
            Cylinder cyl1 = new Cylinder(5,3);
            Sphere sphere2 = new Sphere(4.25);
            Frustum frust2 = new Frustum(3, 2.66474, 3);
            Cylinder cyl2 = new Cylinder(3, 2.66474);

            //neg
            SphericalCap cap1 = new SphericalCap(3, 1.24);
            SphericalCap cap2 = new SphericalCap(3, 1.24);
            SphericalCap cap3 = new SphericalCap(3, 1.24);
            SphericalCap cap4 = new SphericalCap(3, 1.24);
            Cone cone = new Cone(3.48, 1.3);

            double vol = (frust1.volume + sphere1.volume + cyl1.volume + sphere2.volume + frust2.volume + cyl2.volume) -
                         (cap1.volume + cap2.volume + cap3.volume + cap4.volume + cone.volume);

            Console.WriteLine(vol);
        }
    }
}
