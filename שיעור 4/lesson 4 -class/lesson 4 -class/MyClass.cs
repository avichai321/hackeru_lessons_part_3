using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_4__class
{
    interface IEntity
    { 

    }
    class MyClass<T> where T : IEntity
    {
        //MyClass<int> a = new MyClass<int>;
    }
    class MyEntity : IEntity
    {
        MyClass<MyEntity> b = new MyClass<MyEntity>();
    }
}
