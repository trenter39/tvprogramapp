using System.Text.Json;
using TVProgramApp.Models;

namespace TVProgramApp.Services
{
    public class ScheduleService
    {
        private Dictionary<string, Dictionary<string, TvProgram>> _weeklySchedule =
            new Dictionary<string, Dictionary<string, TvProgram>>();
        public IReadOnlyDictionary<string, Dictionary<string, TvProgram>> WeeklySchedule => _weeklySchedule;

        public void AddProgram(string dayOfWeek, string time, TvProgram program)
        {
            if (!_weeklySchedule.ContainsKey(dayOfWeek))
                _weeklySchedule[dayOfWeek] = new Dictionary<string, TvProgram>();

            _weeklySchedule[dayOfWeek][time] = program;
        }

        public void RemoveProgram(string dayOfWeek, string time)
        {
            if( _weeklySchedule.ContainsKey(dayOfWeek))
                _weeklySchedule[dayOfWeek].Remove(time);
        }

        public bool IsTimeUnique(string dayOfWeek, string time) =>
            !_weeklySchedule.ContainsKey(dayOfWeek) || !_weeklySchedule[dayOfWeek].ContainsKey(time);

        public List<TvProgram> GetDaySchedule(string dayOfWeek)
        {
            if (!_weeklySchedule.ContainsKey(dayOfWeek))
                return new List<TvProgram>();

            return _weeklySchedule[dayOfWeek]
                .OrderBy(kv => kv.Key)
                .Select(kv => kv.Value)
                .ToList();
        }

        public List<TvProgram> FindByTime(string dayOfWeek, string time)
        {
            if (!_weeklySchedule.ContainsKey(dayOfWeek))
                return new List<TvProgram>();

            return _weeklySchedule[dayOfWeek]
                .Where(kv => kv.Key == time)
                .Select(kv => kv.Value)
                .ToList();
        }

        public List<TvProgram> FindByName(string dayOfWeek, string nameSearch)
        {
            if (!_weeklySchedule.ContainsKey(dayOfWeek))
                return new List<TvProgram>();

            return _weeklySchedule[dayOfWeek]
                .Values
                .Where(p => p.Name.IndexOf(nameSearch, StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderBy(p => p.Time)
                .ToList();
        }

        public void SerializeToJson(string filePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(_weeklySchedule, options);
            File.WriteAllText(filePath, json);
        }

        public void DeserializeFromJson(string filePath)
        {
            if (!File.Exists(filePath)) return;

            string json = File.ReadAllText(filePath);
            _weeklySchedule = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, TvProgram>>>(json)
                ?? new Dictionary<string, Dictionary<string, TvProgram>>();
        }
    }
}
