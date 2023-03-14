using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatikNesneler;

public class SingletonDeneme
{
    public Guid Id { get; set; }

    private static SingletonDeneme _singletonDeneme;
    private SingletonDeneme()
    {
        Thread.Sleep(10 * 1000);
        this.Id = Guid.NewGuid();
    }
    public static SingletonDeneme GetInstance()
    {
        return _singletonDeneme ?? (_singletonDeneme = new SingletonDeneme());  //?? operatörü null kontrolünü if komutu yazmadan yapar. Aşağıdaki
        //örnekle aynı mantıkta çalışır.

        //return _singletonDeneme ??= new SingletonDeneme();   daha da kısaltılmışı

        //if (_singletonDeneme == null)
        //    _singletonDeneme = new SingletonDeneme();
        //return _singletonDeneme;
    }
    public static SingletonDeneme Instance
    {
        get
        {
            if (_singletonDeneme == null)
                _singletonDeneme = new SingletonDeneme();
            return _singletonDeneme;
        }
    }
}
