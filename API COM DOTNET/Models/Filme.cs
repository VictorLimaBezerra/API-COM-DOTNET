using System.ComponentModel.DataAnnotations;

namespace API_COM_DOTNET.Models;

public class Filme
{   
    public int Id { get; set; }

    [Required(ErrorMessage = "O titulo deve ser obrigatorio e deve ter no maximo 300 caracteres(incluindo as virgulas).")]
    [MaxLength(300, ErrorMessage = "O titulo deve ter no maximo 300 caracteres(incluindo as virgulas).")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "A quantidade de genero esta limitada a 50 caracteres(incluindo as virgulas) e deve ser obrigatorio.")]
    [MaxLength(50, ErrorMessage ="A quantidade de genero esta limitada a 50 caracteres(incluindo as virgulas).")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "O filme deve ter entre 70 a 300 minutos e deve ser obrigatorio.")]
    [Range(70, 300, ErrorMessage = "O filme deve ter entre 70 a 300 minutos e deve ser obrigatorio.")]
    public int Duracao { get; set; }


}

