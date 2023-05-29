﻿namespace LaMiaPizzeria.Models.ModelForViews
{
    public class ProfileListPizzas
    {
        public UserProfile Profile { get; set; }

        public string SearchString { get; set; }

        public List<PizzaModel> ResultPizzas { get; set; }

        public ProfileListPizzas(UserProfile profile, string searchString, List<PizzaModel> resultPizzas)
        {
            Profile = profile;
            SearchString = searchString;
            ResultPizzas = resultPizzas;
        }
    }
}
