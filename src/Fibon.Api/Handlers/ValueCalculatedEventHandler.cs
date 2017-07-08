using System;
using System.Threading.Tasks;
using Fibon.Api.Repository;
using Fibon.Messages.Command;
using Fibon.Messages.Events;
using RawRabbit;

namespace Fibon.Api.Handlers
{
    public class ValueCalculatedEventHandler : IEventHandler<ValueCalculatedEvent>
    {
        private readonly IRepository _repository;

        public ValueCalculatedEventHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task HandleAsync(ValueCalculatedEvent @event)
        {
            await Task.Run(() => _repository.Insert(@event.Number, @event.Value));
        }
    }
}