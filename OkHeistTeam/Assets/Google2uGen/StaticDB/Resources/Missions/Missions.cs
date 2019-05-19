//----------------------------------------------
//    Google2u: Google Doc Unity integration
//         Copyright © 2015 Litteratus
//
//        This file has been auto-generated
//              Do not manually edit
//----------------------------------------------

using UnityEngine;
using System.Globalization;

namespace Google2u
{
	[System.Serializable]
	public class MissionsRow : IGoogle2uRow
	{
		public string _Challenges;
		public string _PassingSkill1;
		public string _PassingSkill2;
		public string _PassingSkill3;
		public string _PassText;
		public string _fAILtEXT;
		public string _Difficulty;
		public string _LikeBonus;
		public string _DislikePenalty;
		public MissionsRow(string __ID, string __Challenges, string __PassingSkill1, string __PassingSkill2, string __PassingSkill3, string __PassText, string __fAILtEXT, string __Difficulty, string __LikeBonus, string __DislikePenalty) 
		{
			_Challenges = __Challenges.Trim();
			_PassingSkill1 = __PassingSkill1.Trim();
			_PassingSkill2 = __PassingSkill2.Trim();
			_PassingSkill3 = __PassingSkill3.Trim();
			_PassText = __PassText.Trim();
			_fAILtEXT = __fAILtEXT.Trim();
			_Difficulty = __Difficulty.Trim();
			_LikeBonus = __LikeBonus.Trim();
			_DislikePenalty = __DislikePenalty.Trim();
		}

		public int Length { get { return 9; } }

		public string this[int i]
		{
		    get
		    {
		        return GetStringDataByIndex(i);
		    }
		}

		public string GetStringDataByIndex( int index )
		{
			string ret = System.String.Empty;
			switch( index )
			{
				case 0:
					ret = _Challenges.ToString();
					break;
				case 1:
					ret = _PassingSkill1.ToString();
					break;
				case 2:
					ret = _PassingSkill2.ToString();
					break;
				case 3:
					ret = _PassingSkill3.ToString();
					break;
				case 4:
					ret = _PassText.ToString();
					break;
				case 5:
					ret = _fAILtEXT.ToString();
					break;
				case 6:
					ret = _Difficulty.ToString();
					break;
				case 7:
					ret = _LikeBonus.ToString();
					break;
				case 8:
					ret = _DislikePenalty.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "Challenges":
					ret = _Challenges.ToString();
					break;
				case "PassingSkill1":
					ret = _PassingSkill1.ToString();
					break;
				case "PassingSkill2":
					ret = _PassingSkill2.ToString();
					break;
				case "PassingSkill3":
					ret = _PassingSkill3.ToString();
					break;
				case "PassText":
					ret = _PassText.ToString();
					break;
				case "fAILtEXT":
					ret = _fAILtEXT.ToString();
					break;
				case "Difficulty":
					ret = _Difficulty.ToString();
					break;
				case "LikeBonus":
					ret = _LikeBonus.ToString();
					break;
				case "DislikePenalty":
					ret = _DislikePenalty.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "Challenges" + " : " + _Challenges.ToString() + "} ";
			ret += "{" + "PassingSkill1" + " : " + _PassingSkill1.ToString() + "} ";
			ret += "{" + "PassingSkill2" + " : " + _PassingSkill2.ToString() + "} ";
			ret += "{" + "PassingSkill3" + " : " + _PassingSkill3.ToString() + "} ";
			ret += "{" + "PassText" + " : " + _PassText.ToString() + "} ";
			ret += "{" + "fAILtEXT" + " : " + _fAILtEXT.ToString() + "} ";
			ret += "{" + "Difficulty" + " : " + _Difficulty.ToString() + "} ";
			ret += "{" + "LikeBonus" + " : " + _LikeBonus.ToString() + "} ";
			ret += "{" + "DislikePenalty" + " : " + _DislikePenalty.ToString() + "} ";
			return ret;
		}
	}
	public sealed class Missions : IGoogle2uDB
	{
		public enum rowIds {
			Challenge_1, Challenge_2, Challenge_3, Challenge_4, Challenge_5, Challenge_6, Challenge_7, Challenge_8, Challenge_9, Challenge_10, Challenge_11, Challenge_12
		};
		public string [] rowNames = {
			"Challenge_1", "Challenge_2", "Challenge_3", "Challenge_4", "Challenge_5", "Challenge_6", "Challenge_7", "Challenge_8", "Challenge_9", "Challenge_10", "Challenge_11", "Challenge_12"
		};
		public System.Collections.Generic.List<MissionsRow> Rows = new System.Collections.Generic.List<MissionsRow>();

		public static Missions Instance
		{
			get { return NestedMissions.instance; }
		}

		private class NestedMissions
		{
			static NestedMissions() { }
			internal static readonly Missions instance = new Missions();
		}

		private Missions()
		{
			Rows.Add( new MissionsRow("Challenge_1", "Distract guards", "Sabotage", "Charm", "Hacking", "%PersonName% ditracted the guards with their exquisite %SkillName%", "%PersonName% had no way to distract the quards so the guard caught them immediate" +
    "ly and are on hightened awareness", "5", "Social", "Shooting"));
			Rows.Add( new MissionsRow("Challenge_2", "Bypass dogs", "Stealth", "Luck", "Social", "%PersonName% got by the dogs with sheer strength of %SkillName%", "%PersonName% had no way to get by the dogs so they got their ass bit and are on h" +
    "ightened awareness", "5", "Dogs", "Dogs"));
			Rows.Add( new MissionsRow("Challenge_3", "Drive getaway car", "Driving", "Pilot", "Luck", "%PersonName% successfully drove the getaway car leaning on their %SkillName% abil" +
    "ities", "%PersonName% crashed the car immediately. Womp Womp", "6", "Cars", "Cars"));
			Rows.Add( new MissionsRow("Challenge_4", "Fight the cops", "MartialArts", "Demolition", "Shooting", "%PersonName% defeated the cops with mad %SkillName% abilities", "The cops tackled %PersonName% easily. Why did they even try?", "5", "Gymnastics", "Shooting"));
			Rows.Add( new MissionsRow("Challenge_5", "Scale the fence", "MartialArts", "Athletics", "Stealth", "%PersonName% scaled the fence easily with slick %SkillName% skills", "Why did %PersonName% even try to get over the fence? They failed miserably", "5", "Gymnastics", "Sports"));
			Rows.Add( new MissionsRow("Challenge_6", "Break into safe", "SafeCracking", "SleightOfHand", "Hacking", "%PersonName% got right into the safe with their sweet %SkillName% abilities", "Damn it AppleJack! %PersonName% couldn\'t even come close to cracking the safe", "5", "Puzzles", "Puzzles"));
			Rows.Add( new MissionsRow("Challenge_7", "Obtain safe room code", "Hacking", "Connections", "Charm", "%PersonName% got the code for the safe room using %SkillName%", "No safe room code for this team because %PersonName% just wasn\'t up to it", "5", "Social", "Social"));
			Rows.Add( new MissionsRow("Challenge_8", "Fence/hide stolen goods", "Connections", "SleightOfHand", "Finance", "%PersonName% was able to use their %SkillName% to fence the goods", "Who would deal with %PersonName% to fence stolen property? No one it seems", "5", "Parties", "Parties"));
			Rows.Add( new MissionsRow("Challenge_9", "Shut off the alarms", "Sabotage", "Stealth", "SleightOfHand", "%PersonName% shut off the alarms with ease using %SkillName%", "The alarms are still active \'cuz %PersonName% had no idea how to turn them off an" +
    "d now they\'re busted", "5", "Crafts", "Social"));
			Rows.Add( new MissionsRow("Challenge_10", "Building schematics", "Construction", "Academic", "Hacking", "%PersonName% created schematics by using their ill %SkillName% talents", "Schematics schmematics - no schematics for the team because %PersonName% is a bum" +
    "", "5", "Reading", "Reading"));
			Rows.Add( new MissionsRow("Challenge_11", "Avoid laser tripwires", "Athletics", "Stealth", "Sabotage", "%PersonName% defly avoided the lase tripwires with their sweet %SkillName%", "%PersonName% just stumbled right into the laser tripwires like a dang amateur", "5", "Gymnastics", "Shooting"));
			Rows.Add( new MissionsRow("Challenge_12", "Blow hole in wall", "Demolition", "MartialArts", "Shooting", "%PersonName% used their insane %SkillName% to blow a massive hole in a wall", "", "5", "Sports", "Public Transport"));
		}
		public IGoogle2uRow GetGenRow(string in_RowString)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}
		public IGoogle2uRow GetGenRow(rowIds in_RowID)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public MissionsRow GetRow(rowIds in_RowID)
		{
			MissionsRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public MissionsRow GetRow(string in_RowString)
		{
			MissionsRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}

	}

}
