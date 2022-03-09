using ServiceDesk.API.Models;

namespace ServiceDesk.API.Services
{
    public interface IPanelPasswordService
    {
        Task<IEnumerable<PanelModel>> GetLastThreePassword(int lastFivePassWord);
        Task InsertPanelPassword(PanelModel panelModelViewModel);
    }
}
