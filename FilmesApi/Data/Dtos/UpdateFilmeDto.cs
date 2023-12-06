﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class UpdateFilmeDto 
    {
        public string Titulo { get; set; }
    
        [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exeder 50 caracteres")]
        public string Genero { get; set; }
        
        [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos")]
        public int Duracao { get; set; }
        
    }
}
