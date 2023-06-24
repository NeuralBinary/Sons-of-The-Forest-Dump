using System;
using Il2CppDummyDll;
using PathologicalGames;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007AD RID: 1965
	[Token(Token = "0x20007AD")]
	public class VirtualPickupData : IDisposable
	{
		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060034F6 RID: 13558 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
		[Token(Token = "0x170006B0")]
		public float Lifetime
		{
			[Token(Token = "0x60034F6")]
			[Address(RVA = "0x34D5960", Offset = "0x34D3F60", VA = "0x1834D5960")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F7")]
		[Address(RVA = "0x34D59C0", Offset = "0x34D3FC0", VA = "0x1834D59C0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060034F8 RID: 13560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public VirtualPickupData()
		{
		}

		// Token: 0x04002DB2 RID: 11698
		[Token(Token = "0x4002DB2")]
		[FieldOffset(Offset = "0x10")]
		public ItemInstance ItemInstance;

		// Token: 0x04002DB3 RID: 11699
		[Token(Token = "0x4002DB3")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 Position;

		// Token: 0x04002DB4 RID: 11700
		[Token(Token = "0x4002DB4")]
		[FieldOffset(Offset = "0x24")]
		public Quaternion Rotation;

		// Token: 0x04002DB5 RID: 11701
		[Token(Token = "0x4002DB5")]
		[FieldOffset(Offset = "0x34")]
		public float Radius;

		// Token: 0x04002DB6 RID: 11702
		[Token(Token = "0x4002DB6")]
		[FieldOffset(Offset = "0x38")]
		public float ActiveRadius;

		// Token: 0x04002DB7 RID: 11703
		[Token(Token = "0x4002DB7")]
		[FieldOffset(Offset = "0x3C")]
		public bool SpawnInDynamic;

		// Token: 0x04002DB8 RID: 11704
		[Token(Token = "0x4002DB8")]
		[FieldOffset(Offset = "0x3D")]
		public bool ShouldDespawn;

		// Token: 0x04002DB9 RID: 11705
		[Token(Token = "0x4002DB9")]
		[FieldOffset(Offset = "0x3E")]
		public bool UsePooling;

		// Token: 0x04002DBA RID: 11706
		[Token(Token = "0x4002DBA")]
		[FieldOffset(Offset = "0x3F")]
		public bool AnyPlayerInMultiplayer;

		// Token: 0x04002DBB RID: 11707
		[Token(Token = "0x4002DBB")]
		[FieldOffset(Offset = "0x40")]
		public PrefabPool PrefabPool;

		// Token: 0x04002DBC RID: 11708
		[Token(Token = "0x4002DBC")]
		[FieldOffset(Offset = "0x48")]
		public float CreationTime;

		// Token: 0x04002DBD RID: 11709
		[Token(Token = "0x4002DBD")]
		[FieldOffset(Offset = "0x50")]
		public string NameId;

		// Token: 0x04002DBE RID: 11710
		[Token(Token = "0x4002DBE")]
		[FieldOffset(Offset = "0x58")]
		public bool RuntimeCreated;
	}
}
