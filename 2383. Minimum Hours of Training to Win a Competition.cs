public class Solution {
    public int MinNumberOfHours(int initialEnergy, int initialExperience, int[] energy, int[] experience) {
        int energysum = 0;
        for(int i=0;i<energy.Length;i++){
            energysum += energy[i];
        }
        int energyTraining = Math.Max(0, energysum - initialEnergy + 1);
        int currentExperience = initialExperience;
        int experienceTraining = 0;
        for (int i = 0; i < experience.Length; i++) {
            if (currentExperience <= experience[i]) {
                experienceTraining += (experience[i] - currentExperience + 1);
                currentExperience = experience[i] + 1; 
            }
            currentExperience += experience[i];
        }
        return energyTraining + experienceTraining;

    }
}
