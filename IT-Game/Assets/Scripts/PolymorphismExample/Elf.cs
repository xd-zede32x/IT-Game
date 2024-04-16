using UnityEngine;
using ScriptPolymorphism;

namespace ScriptCharacters
{
    public class Elf : Unit
    {
        public override void IssueCry()
        {
            Debug.Log($"Я Эльф с уроном: {Damage} со скоростью: {Speed} пришел показать жалким людишкам их место.");
        }
    }
}