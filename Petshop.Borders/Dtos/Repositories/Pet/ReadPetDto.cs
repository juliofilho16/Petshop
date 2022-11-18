using Petshop.Borders.Dtos.Repositories.Pet;
using Petshop.Borders.Dtos.Repositories.Especie;
using Petshop.Borders.Dtos.Repositories.Raca;
using System.ComponentModel.DataAnnotations;

namespace Petshop.Borders.Dtos.Repositories.Pet
{
    public class ReadPetDto
    {
        public ReadPetDto()
        {
            Especie = new ReadEspecieDto();
            Raca = new ReadRacaDto();
        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public ReadEspecieDto Especie { get; set; }
        public ReadRacaDto Raca { get; set; }
        public int Idade { get; set; }
    }
    public static class ReadPetDtoConversions
    {
        public static ReadPetDto toReadPetDto(this Entities.EntitiesContext.Pet Pet)
        {
            ReadPetDto PetDto = new ReadPetDto();
            PetDto.Id = Pet.Id;
            PetDto.Nome = Pet.Nome;
            PetDto.Idade = Pet.Idade;
            PetDto.Especie.Id = Pet.IdEspecieNavigation.Id;
            PetDto.Especie.Descricao = Pet.IdEspecieNavigation.Descricao;
            PetDto.Raca.Id = Pet.IdRacaNavigation.Id;
            PetDto.Raca.Descricao = Pet.IdRacaNavigation.Descricao;


            return PetDto;
        }
    }
}
