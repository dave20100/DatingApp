using System.Collections.Generic;
using System.Threading.Tasks;
using Api.DTOs;
using Api.Entities;
using Api.Helpers;
using Api.Interfaces;

namespace Api.Data
{
    public class MessageRepository : IMessageRepository
    {
        private readonly DataContext _context;
        public MessageRepository(DataContext context)
        {
            _context = context;
        }

        public void AddMessage(Message message)
        {
            _context.Messages.Add(message);
        }

        public void DeleteMessage(Message message)
        {
            _context.Messages.Remove(message);
        }

        public async Task<Message> GetMessage(int id)
        {
            return await _context.Messages.FindAsync(id);
        }

        public Task<PagedList<MessageDto>> GetMessagesForUser()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<MessageDto>> GetMessageThread(int currentUserId, int recipientId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}