//using System;

/// <summary>
/// Template for Player cards
/// </summary>
public class Player
{
    /// <summary>
    /// Player card info for start of game:
    /// --unique action
    /// --unique ability
    /// --starting item
    /// --starting position
    /// --tickets (train, boat)
    /// --held items
    /// --held spells
    /// --conditions
    /// --health
    /// --sanity
    /// background info text
    /// --sanity death text
    /// --health death text
    /// 
    /// </summary>

    //public variables


    //private variables
    private string startLocation;



    // need to test if this works for dictionary syntax, I think it should
    // dict for held items
    private Dictionary<string, int> items = new Dictionary<string, int>();

    //dict for held spells
    private Dictionary<string, int> spells = new Dictionary<string, int>();

    //dict for status conditions
    private Dictionary<string, bool> statusEffect = new Dictionary<string, bool>();

    private int health;
    private int maxHealth;
    private string healthDeath;

    private int sanity;
    private int maxSanity;
    private string sanityDeath;

    //look into see if string is most appropriate type for these variables
    private string activeSkill;
    private string passiveSkill;


    private int trainTicket;
    private int boatTicket;

    private int lore;
    private int influence;
    private int observation;
    private int strength;
    private int will;


    public Player()
	{
		//
		// TODO: Add constructor logic here
		//

	}

    static void main(string[] args)
    {
        Console.WriteLine("hello")

    }

}
