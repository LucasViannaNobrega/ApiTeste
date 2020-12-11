using System;
using System.ComponentModel.DataAnnotations;

namespace ApiLucas.Model
{
    [Serializable]
    public class Left
    {
         public int Id { get; set; }

        public string Valor { get; set; }

    }
}