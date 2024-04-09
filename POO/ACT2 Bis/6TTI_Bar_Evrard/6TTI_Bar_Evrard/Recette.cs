using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_Bar_Evrard
{
    class Recette
    {
        private List<Portion> _ingredients;

        public Recette(List<Portion> ingredients)
        {
            _ingredients = ingredients;
        }

        public List<Portion> Ingredients
        {
            get { return _ingredients; }
        }
    }
}
