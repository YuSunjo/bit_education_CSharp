using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2._1
{
    class Car
    {
        //private string model;
        //private string color;

        //public Car()                     //생성자
        //{
        //    model = "세단";
        //    color = "흰색";
        //}
        //public Car(string _model , string _color)
        //{
        //    model = _model;
        //    color = _color;
        //}
        //public void ShowStatus()
        //{
        //    WriteLine($"Model : {model}, color: {color}");
        //}

        //~Car()
        //{
        //    WriteLine("소멸자");
        //}

        protected string model;
        protected string powerTrain;

        public Car(string model , string powerTrain)
        {
            this.model = model;
            this.powerTrain = powerTrain;
        }
        public virtual void drive()   
        {
            WriteLine("달린다.");
        }

    }
    class GasolineCar : Car
    {
        public GasolineCar(string model, string powerTrain) : base(model, powerTrain)
        {

        }
        public override void drive()
        {
            //base.drive();
            WriteLine($"{model} {powerTrain} 부르릉");
        }
        //public new void drive()                // 만약 부모꺼 virtual이 안되어있으면 new 를 쓰고  main 에서 객체 생성할 때 부모꺼 말고 
                                                 // 자식 객체를 써야한다. 
        //{
        //    WriteLine($"{model} {powerTrain} 스르륵");
        //}
    }
    class HybridCar : Car
    {
        public HybridCar(string model, string powerTrain) : base(model, powerTrain)
        {

        }
        public override void drive()
        {
            //base.drive();
            WriteLine($"{model} {powerTrain} 스르륵");
        }
    }
}
