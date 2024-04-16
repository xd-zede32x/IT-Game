using UnityEngine;
using ScriptPolymorphism;

namespace ScriptCharacters
{
    public class Ogre : Unit
    {
        public override void IssueCry()
        {
            Debug.Log($"Я Огр с уроном: {Damage} со скоростью: {Speed} прибыл что бы залить поле боя кровью.");
        }
    }
}