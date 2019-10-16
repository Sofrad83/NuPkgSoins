// <copyright file="IntervenantExterne.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ClassesMetier
{
    /// <summary>
    /// classe intervenantexterne héritant de la classe intervenant.
    /// </summary>
    public class IntervenantExterne : Intervenant
    {
        private string specialite;
        private string adresse;
        private string tel;

        /// <summary>
        /// Initializes a new instance of the <see cref="IntervenantExterne"/> class.
        /// constructeur.
        /// </summary>
        /// <param name="nom">.</param>
        /// <param name="prenom">..</param>
        /// <param name="specialite">...</param>
        /// <param name="adresse">....</param>
        /// <param name="tel">.....</param>
        public IntervenantExterne(string nom, string prenom, string specialite, string adresse, string tel)
            : base(nom, prenom)
        {
            this.specialite = specialite;
            this.adresse = adresse;
            this.tel = tel;
        }

        /// <summary>
        /// Gets property de l'attribut specialité.
        /// </summary>
        public string Specialite
        {
            get { return this.specialite; }
        }

        /// <summary>
        /// Gets property de l'attribut adresse.
        /// </summary>
        public string Adresse
        {
            get { return this.adresse; }
        }

        /// <summary>
        /// Gets property de l'attribut tel.
        /// </summary>
        public string Tel
        {
            get { return this.tel; }
        }
        ////////////////////////////////

        /// <inheritdoc/>
        public override string ToString()
        {
            return base.ToString() + " Spécialité : " + this.Specialite + "\n\t\t  " + this.Adresse + " - " + this.Tel;
        }
    }
}
