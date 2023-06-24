using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public class VailNavGraphModifier : GraphModifier
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2A99E60", Offset = "0x2A98460", VA = "0x182A99E60", Slot = "10")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2A9A020", Offset = "0x2A98620", VA = "0x182A9A020", Slot = "11")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2A9A160", Offset = "0x2A98760", VA = "0x182A9A160", Slot = "18")]
		public override void OnGraphsPostUpdate()
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2A9A4E0", Offset = "0x2A98AE0", VA = "0x182A9A4E0")]
		private void MarkUnwalkable()
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2A9A570", Offset = "0x2A98B70", VA = "0x182A9A570")]
		private void ActivateLinks()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2A9A840", Offset = "0x2A98E40", VA = "0x182A9A840")]
		public void Tick()
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2A9AAA0", Offset = "0x2A990A0", VA = "0x182A9AAA0")]
		private void OnNavCutEnable(NavmeshClipper cut)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2A9AB00", Offset = "0x2A99100", VA = "0x182A9AB00")]
		private void OnNavCutDisable(NavmeshClipper cut)
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2A9AB50", Offset = "0x2A99150", VA = "0x182A9AB50")]
		private void UpdateNavCuts()
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2A9AD40", Offset = "0x2A99340", VA = "0x182A9AD40")]
		public static void RegisterCustomMeshAdd(NavMeshCustomMeshAdd customMeshAdd)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2A9AE00", Offset = "0x2A99400", VA = "0x182A9AE00")]
		public static void UnRegisterCustomMeshAdd(NavMeshCustomMeshAdd customMeshAdd)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2A9AE80", Offset = "0x2A99480", VA = "0x182A9AE80")]
		public static void RecalculateNavGraph()
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2A9B0D0", Offset = "0x2A996D0", VA = "0x182A9B0D0")]
		public VailNavGraphModifier()
		{
		}

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Re-mark isolated regions un-walkable after a nav graph update (eg. nav cuts applied)")]
		private int _markUnwalkableLimit;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x44")]
		private int _markedUnwalkable;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x48")]
		private uint _largestArea;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x0")]
		private static int _navCutsEnabled;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x4")]
		private static int _navCutsDisabled;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x8")]
		private static List<NavMeshCustomMeshAdd> _customMeshAddList;
	}
}
