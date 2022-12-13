using JmSantosAT_Final_Rafael.Data;

namespace JmSantosAT_Final_Rafael.Models
{
    public class AmigoRepository : IAmigo
    {
        private readonly ReadOnly _readOnlyRepository;

        public AmigoRepository(ReadOnly readOnlyRepository)
        {
            _readOnlyRepository = readOnlyRepository;
        }

        public IEnumerable<Amigo> GetAllFriends()
        {
            return _readOnlyRepository.GetAll();
        }
    }
}
