using Awesomeshop.Services.Orders.Core.Events;

namespace Awesomeshop.Services.Orders.Core.Entities
{
    public class AggregateRoot : IEntityBase
    {
        private List<IDomainEvent> _events = new List<IDomainEvent>();
        public Guid Id { get; protected set; }

        public IEnumerable<IDomainEvent> Events => _events;

        protected void AddEvent(IDomainEvent @event){
            if(_events == null) _events = new List<IDomainEvent>();
            _events.Add(@event);
        }
    }
}