namespace WindowsFormsAppPatternBuilder.DBCon
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Burger
    {
        public int ID { get; set; }

        public bool? Cheese { get; set; }

        public bool? Bacon { get; set; }

        public bool? Letuce { get; set; }

        public bool? Tomato { get; set; }

        public bool? Pickles { get; set; }

        public Burger()
        {
            Cheese = false;
            Bacon = false;
            Letuce = false;
            Tomato = false;
            Pickles = false;
        }
    }
}
