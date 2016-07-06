using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Algorithms.Models
{
  public  class CalcPrimeModel
    {
      [DisplayName("Number to Check")]
        public int Numb2Calc { get; set; }
        public bool Answer { get; set; }
    }
}
