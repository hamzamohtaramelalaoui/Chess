
using Condidat.Domain.Enums;
using System.ComponentModel.DataAnnotations;


namespace Condidat.Domain.Entities
{
    public class Region
    {
        public string RegionId { get; set; }
        public string Name { get; set; }

    }
}


namespace Condidat.Domain.Entities
{
    public class Ville
    {
        public string VilleId { get; set; }
        public string Name { get; set; }
        public string RegionId { get; set; }

    }
}


namespace Condidat.Domain.Entities
{
    public class Commune
    {
        public string CommuneId { get; set; }
        public string Name { get; set; }
        public string VilleId { get; set; }

    }
}


namespace Condidat.Domain.Entities
{
    public class Condidate
    {
        [Key]
        [Required]
        public string CondidatId { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        [Required]
        public DateTime DateNaissance { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        public string Adresse { get; set; }

        public Sexe sexe { get; set; }

        [Required]
        public string ville { get; set; }

        [Required]
        public string commune { get; set; }

        [Required]
        public string region { get; set; }

        [Required]
        public Situation Situation { get; set; }

        [Required]
        public string Source { get; set; }

    }
}
