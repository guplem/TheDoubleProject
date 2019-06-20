using UnityEngine;

//[CreateAssetMenu(fileName = "New Character Properties", menuName = "Models/Properties/CharacterProperties")]
[System.Serializable]
public class CharacterProperties
{
    public string name;
    [TextArea]
    public string description;

    //Default values
    public CharacterProperties()
    {
        this.name = "WRITE HERE THE NAME";
        this.description = "WRITE HERE THE DESCRIPTION";
    }
}