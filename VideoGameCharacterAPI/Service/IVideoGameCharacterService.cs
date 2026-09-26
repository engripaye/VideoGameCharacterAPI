using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.Service;

public interface IVideoGameCharacterService
{
    Task<List<Character>> GetAllCharactersAsync();
    Task<Character> GetCharacterByIdAsync();
    Task<Character> AddCharacterAsync();
}