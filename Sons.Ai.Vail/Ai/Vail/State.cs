using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	[Serializable]
	public struct State : IEquatable<State>, IEquatable<int>
	{
		// Token: 0x0600060A RID: 1546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x2B316D0", Offset = "0x2B2FCD0", VA = "0x182B316D0")]
		private State(int id, string name, Color color)
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x00004BA8 File Offset: 0x00002DA8
		[Token(Token = "0x17000068")]
		public static State Default
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x2B31730", Offset = "0x2B2FD30", VA = "0x182B31730")]
			get
			{
				return default(State);
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x2B317A0", Offset = "0x2B2FDA0", VA = "0x182B317A0")]
		public static List<State> GetAll()
		{
			return null;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x2B31800", Offset = "0x2B2FE00", VA = "0x182B31800")]
		public static IEnumerable GetTreeViewValues()
		{
			return null;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x2B31890", Offset = "0x2B2FE90", VA = "0x182B31890", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00004BD8 File Offset: 0x00002DD8
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x74B700", Offset = "0x749D00", VA = "0x18074B700")]
		public Color GetColor()
		{
			return default(Color);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050")]
		public int GetId()
		{
			return 0;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x9C2AC0", Offset = "0x9C10C0", VA = "0x1809C2AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x60E0F0", Offset = "0x60C6F0", VA = "0x18060E0F0", Slot = "4")]
		public bool Equals(State other)
		{
			return default(bool);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x5DC410", Offset = "0x5DAA10", VA = "0x1805DC410", Slot = "5")]
		public bool Equals(int other)
		{
			return default(bool);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00004C38 File Offset: 0x00002E38
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x2B318F0", Offset = "0x2B2FEF0", VA = "0x182B318F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00004C50 File Offset: 0x00002E50
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x60E0F0", Offset = "0x60C6F0", VA = "0x18060E0F0")]
		public static bool operator ==(State stateA, State stateB)
		{
			return default(bool);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00004C68 File Offset: 0x00002E68
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x2B319E0", Offset = "0x2B2FFE0", VA = "0x182B319E0")]
		public static bool operator !=(State stateA, State stateB)
		{
			return default(bool);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x2B31A40", Offset = "0x2B30040", VA = "0x182B31A40")]
		public static State Find(int stateId)
		{
			return default(State);
		}

		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private int _id;

		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x8")]
		[HideInInspector]
		[SerializeField]
		private string _name;

		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[HideInInspector]
		private Color _color;

		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly State Invalid;

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x20")]
		public static readonly State None;

		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0x40")]
		public static readonly State Any;

		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		[FieldOffset(Offset = "0x60")]
		public static readonly State Combat;

		// Token: 0x040004E3 RID: 1251
		[Token(Token = "0x40004E3")]
		[FieldOffset(Offset = "0x80")]
		public static readonly State World;

		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly State Sleeping;

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly State Dying;

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0xE0")]
		public static readonly State Injured;

		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0x100")]
		public static readonly State Dead;

		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0x120")]
		public static readonly State Flying;

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		[FieldOffset(Offset = "0x140")]
		public static readonly State Stalking;

		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		[FieldOffset(Offset = "0x160")]
		public static readonly State Burning;

		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		[FieldOffset(Offset = "0x180")]
		public static readonly State Electrocuted;

		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		[FieldOffset(Offset = "0x1A0")]
		public static readonly State Swimming;

		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		[FieldOffset(Offset = "0x1C0")]
		public static readonly State Stunned;

		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		[FieldOffset(Offset = "0x1E0")]
		public static readonly State Drowning;

		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		[FieldOffset(Offset = "0x200")]
		public static readonly State Hit;

		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x40004F0")]
		[FieldOffset(Offset = "0x220")]
		public static readonly State Thrown;

		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x40004F1")]
		[FieldOffset(Offset = "0x240")]
		public static readonly State OnRock;

		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x40004F2")]
		[FieldOffset(Offset = "0x260")]
		public static readonly State OnTree;

		// Token: 0x040004F3 RID: 1267
		[Token(Token = "0x40004F3")]
		[FieldOffset(Offset = "0x280")]
		public static readonly State UnderLeaves;

		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		[FieldOffset(Offset = "0x2A0")]
		public static readonly State WallWalking;

		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		[FieldOffset(Offset = "0x2C0")]
		public static readonly State Captured;

		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x40004F6")]
		[FieldOffset(Offset = "0x2E0")]
		public static readonly State BossIntro;

		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		[FieldOffset(Offset = "0x300")]
		public static readonly State SpawnIntro;

		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x40004F8")]
		[FieldOffset(Offset = "0x320")]
		public static readonly State LeaveCombat;

		// Token: 0x040004F9 RID: 1273
		[Token(Token = "0x40004F9")]
		[FieldOffset(Offset = "0x340")]
		public static readonly State Despawned;

		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x40004FA")]
		[FieldOffset(Offset = "0x360")]
		private static readonly List<State> _all;
	}
}
