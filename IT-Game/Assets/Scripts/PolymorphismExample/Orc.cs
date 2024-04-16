using UnityEngine;
using ScriptPolymorphism;

namespace ScriptCharacters
{
    public class Orc : Unit
    {
        public override void IssueCry()
        {
            Debug.Log($"Я Орк с уроном: {Damage} со скоростью: {Speed} появился на поле битвы и готов разорвать врагов на части.");
        }
    }
}