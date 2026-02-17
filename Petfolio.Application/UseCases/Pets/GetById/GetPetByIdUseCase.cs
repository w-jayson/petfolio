using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById
{
    public class GetPetByIdUseCase
    {
        public ResponsePetJson Execute(int id)
        {
            return new ResponsePetJson
            {
                Id = id,
                Name = "Shawa",
                Birthday = new DateTime(year:2020, month:1, day:1),
                Type = Communication.Enums.PetType.Cat
            };
        }
    }
}
