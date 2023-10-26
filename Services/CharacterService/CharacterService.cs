using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character { Id = 1, Name = "Sam"}
        };

        public async Task <ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task <ServiceResponse<List<Character>>> GetAllCharacters()
        {
            return (characters);

        }

        public async Task <ServiceResponse<Character>> GetCharacterById(int id)
        {
            var character = characters.FirstOrDefault(c => c.Id == id);

            if(character is not null){
                return character;
            }

            throw new Exception("character not found");

        }
    }
}