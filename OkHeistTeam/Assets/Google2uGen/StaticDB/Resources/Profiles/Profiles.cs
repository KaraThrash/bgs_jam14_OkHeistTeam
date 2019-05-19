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
	public class ProfilesRow : IGoogle2uRow
	{
		public string _Name;
		public string _Like_Text;
		public string _Dislike_Text;
		public string _Skills_Text;
		public string _Description;
		public string _Skill_ID_1;
		public string _Skill_ID_2;
		public string _Skill_ID_3;
		public string _Like_ID_1;
		public string _Idle_ID_2;
		public string _Idle_ID_3;
		public string _Dislile_ID_1;
		public string _Dislile_ID_2;
		public string _Dislile_ID_3;
		public ProfilesRow(string __ID, string __Name, string __Like_Text, string __Dislike_Text, string __Skills_Text, string __Description, string __Skill_ID_1, string __Skill_ID_2, string __Skill_ID_3, string __Like_ID_1, string __Idle_ID_2, string __Idle_ID_3, string __Dislile_ID_1, string __Dislile_ID_2, string __Dislile_ID_3) 
		{
			_Name = __Name.Trim();
			_Like_Text = __Like_Text.Trim();
			_Dislike_Text = __Dislike_Text.Trim();
			_Skills_Text = __Skills_Text.Trim();
			_Description = __Description.Trim();
			_Skill_ID_1 = __Skill_ID_1.Trim();
			_Skill_ID_2 = __Skill_ID_2.Trim();
			_Skill_ID_3 = __Skill_ID_3.Trim();
			_Like_ID_1 = __Like_ID_1.Trim();
			_Idle_ID_2 = __Idle_ID_2.Trim();
			_Idle_ID_3 = __Idle_ID_3.Trim();
			_Dislile_ID_1 = __Dislile_ID_1.Trim();
			_Dislile_ID_2 = __Dislile_ID_2.Trim();
			_Dislile_ID_3 = __Dislile_ID_3.Trim();
		}

		public int Length { get { return 14; } }

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
					ret = _Name.ToString();
					break;
				case 1:
					ret = _Like_Text.ToString();
					break;
				case 2:
					ret = _Dislike_Text.ToString();
					break;
				case 3:
					ret = _Skills_Text.ToString();
					break;
				case 4:
					ret = _Description.ToString();
					break;
				case 5:
					ret = _Skill_ID_1.ToString();
					break;
				case 6:
					ret = _Skill_ID_2.ToString();
					break;
				case 7:
					ret = _Skill_ID_3.ToString();
					break;
				case 8:
					ret = _Like_ID_1.ToString();
					break;
				case 9:
					ret = _Idle_ID_2.ToString();
					break;
				case 10:
					ret = _Idle_ID_3.ToString();
					break;
				case 11:
					ret = _Dislile_ID_1.ToString();
					break;
				case 12:
					ret = _Dislile_ID_2.ToString();
					break;
				case 13:
					ret = _Dislile_ID_3.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "Name":
					ret = _Name.ToString();
					break;
				case "Like_Text":
					ret = _Like_Text.ToString();
					break;
				case "Dislike_Text":
					ret = _Dislike_Text.ToString();
					break;
				case "Skills_Text":
					ret = _Skills_Text.ToString();
					break;
				case "Description":
					ret = _Description.ToString();
					break;
				case "Skill_ID_1":
					ret = _Skill_ID_1.ToString();
					break;
				case "Skill_ID_2":
					ret = _Skill_ID_2.ToString();
					break;
				case "Skill_ID_3":
					ret = _Skill_ID_3.ToString();
					break;
				case "Like_ID_1":
					ret = _Like_ID_1.ToString();
					break;
				case "Idle_ID_2":
					ret = _Idle_ID_2.ToString();
					break;
				case "Idle_ID_3":
					ret = _Idle_ID_3.ToString();
					break;
				case "Dislile_ID_1":
					ret = _Dislile_ID_1.ToString();
					break;
				case "Dislile_ID_2":
					ret = _Dislile_ID_2.ToString();
					break;
				case "Dislile_ID_3":
					ret = _Dislile_ID_3.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "Name" + " : " + _Name.ToString() + "} ";
			ret += "{" + "Like_Text" + " : " + _Like_Text.ToString() + "} ";
			ret += "{" + "Dislike_Text" + " : " + _Dislike_Text.ToString() + "} ";
			ret += "{" + "Skills_Text" + " : " + _Skills_Text.ToString() + "} ";
			ret += "{" + "Description" + " : " + _Description.ToString() + "} ";
			ret += "{" + "Skill_ID_1" + " : " + _Skill_ID_1.ToString() + "} ";
			ret += "{" + "Skill_ID_2" + " : " + _Skill_ID_2.ToString() + "} ";
			ret += "{" + "Skill_ID_3" + " : " + _Skill_ID_3.ToString() + "} ";
			ret += "{" + "Like_ID_1" + " : " + _Like_ID_1.ToString() + "} ";
			ret += "{" + "Idle_ID_2" + " : " + _Idle_ID_2.ToString() + "} ";
			ret += "{" + "Idle_ID_3" + " : " + _Idle_ID_3.ToString() + "} ";
			ret += "{" + "Dislile_ID_1" + " : " + _Dislile_ID_1.ToString() + "} ";
			ret += "{" + "Dislile_ID_2" + " : " + _Dislile_ID_2.ToString() + "} ";
			ret += "{" + "Dislile_ID_3" + " : " + _Dislile_ID_3.ToString() + "} ";
			return ret;
		}
	}
	public sealed class Profiles : IGoogle2uDB
	{
		public enum rowIds {
			PROFILE_1, PROFILE_2, PROFILE_3, PROFILE_4, PROFILE_5, PROFILE_6, PROFILE_7, PROFILE_8, PROFILE_9, PROFILE_10, PROFILE_11, PROFILE_12
		};
		public string [] rowNames = {
			"PROFILE_1", "PROFILE_2", "PROFILE_3", "PROFILE_4", "PROFILE_5", "PROFILE_6", "PROFILE_7", "PROFILE_8", "PROFILE_9", "PROFILE_10", "PROFILE_11", "PROFILE_12"
		};
		public System.Collections.Generic.List<ProfilesRow> Rows = new System.Collections.Generic.List<ProfilesRow>();

		public static Profiles Instance
		{
			get { return NestedProfiles.instance; }
		}

		private class NestedProfiles
		{
			static NestedProfiles() { }
			internal static readonly Profiles instance = new Profiles();
		}

		private Profiles()
		{
			Rows.Add( new ProfilesRow("PROFILE_1", "Dominic", "Puppies, muscle cars, puzzles", "Mushrooms, small talk, children", "Driving, shooting", "I show up, I do my work, I get paid, I go home. You don’t bother me, I won’t both" +
    "er you.", "Driving", "Shooting", "Empty", "Dogs", "Cars", "Puzzles", "Drugs", "Social", "Kids"));
			Rows.Add( new ProfilesRow("PROFILE_2", "Tommy", "Driving, reading, napping", "Dogs, guns, being bored", "Driving, safe cracking", @"Hello! I’m Tommy. I’ve been a dedicated safe cracker for 23 years. I think a team works better together when everyone knows something about each other! I love chatting with my coworkers and getting to know what makes them tick. I’m available any day of the week except Sundays, as I will be spending the day at church with my family.", "Driving", "SafeCracking", "Empty", "Cars", "Reading", "Sleep", "Dogs", "Shooting", "Boredom"));
			Rows.Add( new ProfilesRow("PROFILE_3", "Art", "Pottery, surfing, skiing", "Drinking, guns, babysitting", "Karate, networking", @"I enjoy meeting new people, and I’m great at finding common ground with just about anyone. However, I know how to buckle down; I never waste time on chit-chat when there’s work to be done. I refuse to carry a gun, but if things go south, I’m handy to have around because my fists are considered lethal weapons.", "MartialArts", "Social", "Empty", "Crafts", "Sufing", "Skiing", "Drugs", "Shooting", "Kids"));
			Rows.Add( new ProfilesRow("PROFILE_4", "Christine", "Archery, puzzles, children", "Small talk, cooking, cars", "Sniping, code cracking", "I’ve never encountered a code I can’t crack or a target I can’t hit. I care deepl" +
    "y about the environment, which is why I bike, walk, or take public transit only;" +
    " I will not get in a car.", "Shooting", "Hacking", "Empty", "Shooting", "Puzzles", "Kids", "Social", "Food", "Cars"));
			Rows.Add( new ProfilesRow("PROFILE_5", "Delilah", "God, parties, investing", "Puzzles, hiking, pineapple", "Networking, shooting", @"Hi there! I’m so excited to be part of your team! I consider myself to be an extrovert – there’s nothing I like better than being surrounded by a bunch of new people! I’ll talk to anyone about anything, but my favorite topic is guns. I’m an expert sharpshooter and I love to discuss the pros and cons of various types of guns.", "Social", "Shooting", "Empty", "Religion", "Parties", "Money", "Puzzles", "Hiking", "Food"));
			Rows.Add( new ProfilesRow("PROFILE_6", "Holly", "Painting, reading, gymnastics", "Religion, cooking, puzzles", "Karate, safe cracking", "I won’t fight unless I have to. But if I do have to, you’d better believe I fight" +
    " to win.", "MartialArts", "SafeCracking", "Empty", "Crafts", "Reading", "Gymnastics", "Religion", "Food", "Puzzles"));
			Rows.Add( new ProfilesRow("PROFILE_7", "Sam", "Hunting, movies, skiing", "Public transport, dogs, cooking", "Driving, sniping", "I have social anxiety, so I’m not great at talking to new people. When I’m out on" +
    " a job, I prefer to stay on the sidelines and help from afar. But what I lack in" +
    " social skills, I make up for in loyalty and trustworthiness.", "", "", "", "", "", "", "", "", ""));
			Rows.Add( new ProfilesRow("PROFILE_8", "Alonzo", "Parties, animals, gymnastics", "Children, nature, kale", "Karate, code cracking", "Greetings! My name is Alonzo. I have many talents, and I’d love to discuss them w" +
    "ith you in person. I’m not great at these profiles, but I’m very personable and " +
    "friendly.", "", "", "", "", "", "", "", "", ""));
			Rows.Add( new ProfilesRow("PROFILE_9", "Vanessa", "Carpentry, dancing, biking", "Drinking, small talk, cars", "Hotwiring, safe cracking", "My best assets are my time management and my ability to repair just about anythin" +
    "g that’s broken. Tools, furniture, windows – you name it, I can fix it. I’m a ja" +
    "ck of all trades, master of none.", "", "", "", "", "", "", "", "", ""));
			Rows.Add( new ProfilesRow("PROFILE_10", "Gordon", "Scotch, reading, cars", "Public transport, dogs, chick flicks", "Hotwiring, driving", @"Hello all, my name is Gordon. To be quite honest, I’m not sure exactly why I have this profile; until recently I’d had no trouble finding jobs the old-fashioned way, but I suppose we all must evolve with the times, so here I am. I enjoy meeting new people, but I am quite shy at first and tend to hold my tongue until I know someone better.", "", "", "", "", "", "", "", "", ""));
			Rows.Add( new ProfilesRow("PROFILE_11", "Kelly", "Animals, eating healthy, gymnastics", "Movies, puzzles, golf", "Networking, sniping", "I’m small, fast, and good at talking. I’m also a crack shot thanks to my grandma," +
    " who used to help me with my target practice.", "", "", "", "", "", "", "", "", ""));
			Rows.Add( new ProfilesRow("PROFILE_12", "Stu", "Discus, competitive eating, dogs", "Open water, comedians, chick flicks", "Computers, shooting", "I went to school for architecture, but I dropped out because I didn’t want to spe" +
    "nd my days contributing to the capitalist economy that oppresses the masses whil" +
    "e helping the rich get richer. ¡Viva la revolución!", "", "", "", "", "", "", "", "", ""));
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
		public ProfilesRow GetRow(rowIds in_RowID)
		{
			ProfilesRow ret = null;
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
		public ProfilesRow GetRow(string in_RowString)
		{
			ProfilesRow ret = null;
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
