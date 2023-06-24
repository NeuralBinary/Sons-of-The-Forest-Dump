using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	[Serializable]
	public class GroupListItem : IComparer<GroupListItem>, IComparable<GroupListItem>, IComparable, IComparer
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x17000063")]
		public string Name
		{
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x2B22500", Offset = "0x2B20B00", VA = "0x182B22500")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00004680 File Offset: 0x00002880
		[Token(Token = "0x17000064")]
		public bool HasFlagMoveUp
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x150B770", Offset = "0x1509D70", VA = "0x18150B770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00004698 File Offset: 0x00002898
		[Token(Token = "0x17000065")]
		public bool HasFlagMoveDown
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x2B22510", Offset = "0x2B20B10", VA = "0x182B22510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1522030", Offset = "0x1520630", VA = "0x181522030")]
		public void SetFlagMoveUp(bool value)
		{
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x2B22520", Offset = "0x2B20B20", VA = "0x182B22520")]
		public void SetFlagMoveDown(bool value)
		{
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
		public Group GetGroup()
		{
			return null;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public void SetGroup(Group group)
		{
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x000046B0 File Offset: 0x000028B0
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x2B22530", Offset = "0x2B20B30", VA = "0x182B22530")]
		public Color GetGroupPriorityBackgroundColor()
		{
			return default(Color);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x2B226E0", Offset = "0x2B20CE0", VA = "0x182B226E0")]
		public string GetName()
		{
			return null;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x2B227E0", Offset = "0x2B20DE0", VA = "0x182B227E0")]
		public void OnValidate()
		{
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000046C8 File Offset: 0x000028C8
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
		internal int GetIndex()
		{
			return 0;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
		internal void SetIndex(int index)
		{
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000046E0 File Offset: 0x000028E0
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x2B228C0", Offset = "0x2B20EC0", VA = "0x182B228C0", Slot = "4")]
		public int Compare(GroupListItem x, GroupListItem y)
		{
			return 0;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x000046F8 File Offset: 0x000028F8
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x2B22900", Offset = "0x2B20F00", VA = "0x182B22900", Slot = "7")]
		public int Compare(object x, object y)
		{
			return 0;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00004710 File Offset: 0x00002910
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x2B22A00", Offset = "0x2B21000", VA = "0x182B22A00", Slot = "6")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x2B22AC0", Offset = "0x2B210C0", VA = "0x182B22AC0", Slot = "5")]
		public int CompareTo(GroupListItem other)
		{
			return 0;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public GroupListItem()
		{
		}

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Group _group;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x18")]
		private int _editorIndex;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x1C")]
		private bool _flagMoveUp;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x1D")]
		private bool _flagMoveDown;
	}
}
