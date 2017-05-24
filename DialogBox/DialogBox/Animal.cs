using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DialogBox {
  public class Animal {
    private string _name;

    //public string Name { get; set; }
    public string Name {
      get {
        return _name;
      }
      set {
        Regex rx = new Regex("^[ A-Za-z'-]"); // on accept espace ', -
        if (!rx.IsMatch(value)) {
          throw new AccessViolationException("Caractère interdit"); 
        }
        _name = value;
      }
    }

    public string Price { get; set; }

  }


}
