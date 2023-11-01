using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        //instead of using the models here, we pass the Dtos as type
        Task <ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

        Task <ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

        Task <ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);

        Task <ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);

        Task <ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);

    }
}