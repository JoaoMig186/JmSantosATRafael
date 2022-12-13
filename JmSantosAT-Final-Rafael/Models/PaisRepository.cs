using JmSantosAT_Final_Rafael.Data;

namespace JmSantosAT_Final_Rafael.Models
{
    public class PaisRepository : IPais
    {
        private readonly ReadOnly _readOnlyRepository;

        public PaisRepository(ReadOnly readOnlyRepository)
        {
            _readOnlyRepository = readOnlyRepository;
        }
        public IEnumerable<Pais> TodosPaises()
        {
            return _readOnlyRepository.GetAllPaises();
        }
    }
}