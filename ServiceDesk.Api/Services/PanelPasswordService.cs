using Microsoft.EntityFrameworkCore;
using ServiceDesk.API.Models;
using ServiceDesk.API.Context;

namespace ServiceDesk.API.Services
{
    public class PanelPasswordService : IPanelPasswordService
    {
        private readonly AppDbContext _context;

        public PanelPasswordService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PanelModel>> GetLastThreePassword(int getLastFivePassword)
        {
            return await _context.PanelModels.OrderByDescending(id => id.Id).Take(getLastFivePassword).ToListAsync();
        }

        public async Task InsertPanelPassword(PanelModel panelViewModel)
        {
            _context.PanelModels.Add(panelViewModel);
            await _context.SaveChangesAsync();
        }
    }
}
