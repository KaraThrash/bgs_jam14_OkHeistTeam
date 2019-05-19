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
				case "_Name":
					ret = _Name.ToString();
					break;
				case "_Like_Text":
					ret = _Like_Text.ToString();
					break;
				case "_Dislike_Text":
					ret = _Dislike_Text.ToString();
					break;
				case "_Skills_Text":
					ret = _Skills_Text.ToString();
					break;
				case "_Description":
					ret = _Description.ToString();
					break;
				case "_Skill_ID_1":
					ret = _Skill_ID_1.ToString();
					break;
				case "_Skill_ID_2":
					ret = _Skill_ID_2.ToString();
					break;
				case "_Skill_ID_3":
					ret = _Skill_ID_3.ToString();
					break;
				case "_Like_ID_1":
					ret = _Like_ID_1.ToString();
					break;
				case "_Idle_ID_2":
					ret = _Idle_ID_2.ToString();
					break;
				case "_Idle_ID_3":
					ret = _Idle_ID_3.ToString();
					break;
				case "_Dislile_ID_1":
					ret = _Dislile_ID_1.ToString();
					break;
				case "_Dislile_ID_2":
					ret = _Dislile_ID_2.ToString();
					break;
				case "_Dislile_ID_3":
					ret = _Dislile_ID_3.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "_Name" + " : " + _Name.ToString() + "} ";
			ret += "{" + "_Like_Text" + " : " + _Like_Text.ToString() + "} ";
			ret += "{" + "_Dislike_Text" + " : " + _Dislike_Text.ToString() + "} ";
			ret += "{" + "_Skills_Text" + " : " + _Skills_Text.ToString() + "} ";
			ret += "{" + "_Description" + " : " + _Description.ToString() + "} ";
			ret += "{" + "_Skill_ID_1" + " : " + _Skill_ID_1.ToString() + "} ";
			ret += "{" + "_Skill_ID_2" + " : " + _Skill_ID_2.ToString() + "} ";
			ret += "{" + "_Skill_ID_3" + " : " + _Skill_ID_3.ToString() + "} ";
			ret += "{" + "_Like_ID_1" + " : " + _Like_ID_1.ToString() + "} ";
			ret += "{" + "_Idle_ID_2" + " : " + _Idle_ID_2.ToString() + "} ";
			ret += "{" + "_Idle_ID_3" + " : " + _Idle_ID_3.ToString() + "} ";
			ret += "{" + "_Dislile_ID_1" + " : " + _Dislile_ID_1.ToString() + "} ";
			ret += "{" + "_Dislile_ID_2" + " : " + _Dislile_ID_2.ToString() + "} ";
			ret += "{" + "_Dislile_ID_3" + " : " + _Dislile_ID_3.ToString() + "} ";
			return ret;
		}
	}
	public class Profiles :  Google2uComponentBase, IGoogle2uDB
	{
		public enum rowIds {
			PROFILE_1, PROFILE_2, PROFILE_3, PROFILE_4, PROFILE_5, PROFILE_6, PROFILE_7, PROFILE_8, PROFILE_9, PROFILE_10, PROFILE_11, PROFILE_12
		};
		public string [] rowNames = {
			"PROFILE_1", "PROFILE_2", "PROFILE_3", "PROFILE_4", "PROFILE_5", "PROFILE_6", "PROFILE_7", "PROFILE_8", "PROFILE_9", "PROFILE_10", "PROFILE_11", "PROFILE_12"
		};
		public System.Collections.Generic.List<ProfilesRow> Rows = new System.Collections.Generic.List<ProfilesRow>();
		public override void AddRowGeneric (System.Collections.Generic.List<string> input)
		{
			Rows.Add(new ProfilesRow(input[0],input[1],input[2],input[3],input[4],input[5],input[6],input[7],input[8],input[9],input[10],input[11],input[12],input[13],input[14]));
		}
		public override void Clear ()
		{
			Rows.Clear();
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
