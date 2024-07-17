using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _5_PokemonProjekt.PokemonAssets
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    internal class DamageRelations
    {
        public List<NoDamageTo> no_damage_to { get; set; }
        public List<HalfDamageTo> half_damage_to { get; set; }
        public List<DoubleDamageTo> double_damage_to { get; set; }
        public List<NoDamageFrom> no_damage_from { get; set; }
        public List<HalfDamageFrom> half_damage_from { get; set; }
        public List<DoubleDamageFrom> double_damage_from { get; set; }
    }

    internal class DoubleDamageFrom
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class DoubleDamageTo
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class GameIndex
    {
        public int game_index { get; set; }
        public Generation generation { get; set; }
    }

    internal class Generation
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class HalfDamageFrom
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class HalfDamageTo
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class Language
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class Move
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class MoveDamageClass
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class Name
    {
        public string name { get; set; }
        public Language language { get; set; }
    }

    internal class NoDamageFrom
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class NoDamageTo
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class PastDamageRelation
    {
        public Generation generation { get; set; }
        public DamageRelations damage_relations { get; set; }
    }

    internal class Pokemon
    {
        public int slot { get; set; }
        public Pokemon pokemon { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    internal class Root
    {
        public int id { get; set; }
        public string name { get; set; }
        public DamageRelations damage_relations { get; set; }
        public List<PastDamageRelation> past_damage_relations { get; set; }
        public List<GameIndex> game_indices { get; set; }
        public Generation generation { get; set; }
        public MoveDamageClass move_damage_class { get; set; }
        public List<Name> names { get; set; }
        public List<Pokemon> pokemon { get; set; }
        public List<Move> moves { get; set; }
    }




}
