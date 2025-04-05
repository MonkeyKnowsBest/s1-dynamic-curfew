using MelonLoader;

namespace ScheduleI.DynamicCurfew
{
    public class ReputationSystem
    {
        // Track and manage player reputation
        private float _currentReputation;
        private const float MAX_REPUTATION = 100f;
        private const float MIN_REPUTATION = 0f;

        public float CurrentReputation
        {
            get => _currentReputation;
            private set => _currentReputation = Mathf.Clamp(value, MIN_REPUTATION, MAX_REPUTATION);
        }

        public void ModifyReputation(float amount)
        {
            // Modify player reputation based on actions
            CurrentReputation += amount;
            MelonLogger.Msg($"Reputation modified. New value: {CurrentReputation}");
        }

        public ReputationLevel GetReputationLevel()
        {
            // Categorize reputation into levels
            if (CurrentReputation < 20) return ReputationLevel.Notorious;
            if (CurrentReputation < 40) return ReputationLevel.Suspicious;
            if (CurrentReputation < 60) return ReputationLevel.Neutral;
            if (CurrentReputation < 80) return ReputationLevel.Respected;
            return ReputationLevel.Legendary;
        }
    }

    public enum ReputationLevel
    {
        Notorious,
        Suspicious,
        Neutral,
        Respected,
        Legendary
    }
}