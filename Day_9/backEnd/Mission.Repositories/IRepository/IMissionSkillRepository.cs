using Mission.Entities.ViewModels.MissionSkill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services.IServise
{
    public interface IMissionSkillRepository
    {
        Task AddMissionSkillAsync(UpsertMissionSkillRequestModel model);
        Task<List<MissionSkillResponseModel>> GetMissionSkillListAsync();
        Task<MissionSkillResponseModel?> GetMissionSkillByIdAsync(int missionSkillId);
        Task<bool> UpdateMissionSkillAsync(UpsertMissionSkillRequestModel model);
        Task<bool> DeleteMissionSkill(int id);
    }
}
