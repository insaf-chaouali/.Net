using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;

namespace WebApplication3.Models
{
    public class Movie
    {
        [Key]
        public Guid Id { get; set; }= Guid.NewGuid(); //generation automatique de clé primaire 
        [Required(ErrorMessage ="le nom du film est requis")] // controle de saisie pour 
        [StringLength(100,  ErrorMessage ="le nom ne doit pas dépasser 100 caracteres")]
        public string Name { get; set; }= string.Empty;
        [Required(ErrorMessage ="la date d'ajout est requize")]
        public DateTime MovieAdded { get; set; }= DateTime.Now;
        [Required(ErrorMessage ="le genre est requis")]
        public Guid GenreId {  get; set; } //clé étrangere
        public Genre ? Genre {  get; set; } //Relation
        public string? PhotoPath { get; set; } //stocle le chemin de l'image uploadéé

    }
}
