using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3;

internal class AppealManager
{
    public void BasvuruYap(ICreditManager cm,List<ILoggerService> ls)
    {
        cm.Hesabla();
        foreach (var item in ls)
        {
            item.Log();
        }
    }
    public void CreditOnBilgiYap(List<ICreditManager>krediler)
    {
        foreach (var kredi in krediler)
        {
            kredi.Hesabla();
        }
    }
}
