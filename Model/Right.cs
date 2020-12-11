using System;
using System.ComponentModel.DataAnnotations;

namespace ApiLucas.Model
{
    [Serializable]
    public class Right
    {
         public int Id { get; set; }

        public string Valor { get; set; }
   
    }
}