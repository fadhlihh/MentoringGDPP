using UnityEngine;

[CreateAssetMenu(fileName = "New Skill", menuName = "Skill/Skill Data")]
public class SkillData : ScriptableObject
{
    public string Name;
    public int MannaCost;
}
