namespace JmSantosAT_Final_Rafael.Models
{
    public class EstadoRepository : IEstado
    {
        private readonly ReadOnly _readOnlyRepository;

        public EstadoRepository(ReadOnly readOnlyRepository)
        {
            _readOnlyRepository = readOnlyRepository;
        }

        public IEnumerable<Estado> TodosEstados()
        {
            return _readOnlyRepository.GetAllEstados();
        }
    }
}
