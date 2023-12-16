namespace Domain.ViewModel;

public class MatriculaViewModel
{
        public int IdMatricula { get; set; }
        public int? IdCurso { get; set; }

        public int? IdUsuario { get; set; }
        public int? IdEstudante { get; set; }
        
        public int? Estado { get; set; }
        
        public int IdNotas { get; set; }

        public int IdProfessor { get; set; }

        public int IdEsudante { get; set; }
        
        public  string? Nome{get; set; }
        
        public  string ? Sexo{get; set; }
        
        public  string ?    Telefone{get; set; }    
        
        public DateTime? Data { get; set; }
         public int ?IdDisciplina { get; set; }
        public TimeSpan? Hora { get; set; }

        public string? Periodo { get; set; }

        public string? Turma { get; set; }

        public string? Sala { get; set; }

        public string? Classe { get; set; }

        public string? NrMecanografico { get; set; }

        public string? AnoLectivo { get; set; }

        public string? Descrição { get; set; }



        public double? Av1_1º { get; set; }

        public double? Av2_1º { get; set; }

        public double? Av3_1º { get; set; }

        public double? Av4_1º { get; set; }

        public double? Mac1_1º { get; set; }

        public double? Npp1_1º { get; set; }
        public double? Npp1_1º2 { get; init; }
        
        public double? NpT1_1º { get; set; }

        public double? Mt1_1º { get; set; }

        public double? Av1_2º { get; set; }

        public double? Av2_2º { get; set; }

        public double? Av3_2º { get; set; }

        public double? Av4_2º { get; set; }

        public double? Mac_2º { get; set; }

        public double? Npp_2º { get; set; }
        public double? Npp_2º2 { get; init; }
        public double? NpT_2º { get; set; }

        public double? Mt_2º { get; set; }

        public double? Av1_3º { get; set; }

        public double? Av2_3º { get; set; }

        public double? Av3_3º { get; set; }

        public double? Av4_3º { get; set; }

        public double? Mac_3º { get; set; }

        public double? Npp_3º { get; set; }

        public double? NpT_3º { get; set; }

        public double? Mt_3º { get; set; }

        public double? Mfd { get; set; }

}