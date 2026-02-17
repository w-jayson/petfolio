using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.GetAll
{
    public class GetAllPetsUseCase
    {
        public ResponseAllPetJson Execute()
        {
            return new ResponseAllPetJson
            {
              Pets = new List<ResponseShortPetJson>
              {
                  new ResponseShortPetJson
                  {
                      Id = 1,
                      Name = "Shawa",
                      Type = 0,
                  }
              }
            };
        }
    }
}