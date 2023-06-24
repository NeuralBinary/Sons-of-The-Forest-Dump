using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.ConstructionBoltToken;

namespace Construction.Multiplayer
{
	// Token: 0x02000281 RID: 641
	[Token(Token = "0x2000281")]
	public abstract class FreeFormStructureCommand
	{
		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x0000BD2C File Offset: 0x00009F2C
		// (set) Token: 0x060013A4 RID: 5028 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000438")]
		public int DBVersion
		{
			[Token(Token = "0x60013A3")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60013A4")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013A5")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		protected void Init(int dbVersion)
		{
		}

		// Token: 0x060013A6 RID: 5030
		[Token(Token = "0x60013A6")]
		public abstract void Execute(ConstructionManager manager);

		// Token: 0x060013A7 RID: 5031 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x2F5AD80", Offset = "0x2F59380", VA = "0x182F5AD80")]
		protected static void LoadLinks(List<StructureID> Links, Structure structure)
		{
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013A8")]
		[Address(RVA = "0x2F5AEC0", Offset = "0x2F594C0", VA = "0x182F5AEC0")]
		protected static void LoadElements(List<ElementID> elementIDs, Structure structure)
		{
		}

		// Token: 0x060013A9 RID: 5033
		[Token(Token = "0x60013A9")]
		public abstract void Dispose();

		// Token: 0x060013AA RID: 5034 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013AA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected FreeFormStructureCommand()
		{
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60013AB")]
		[Address(RVA = "0x2F5B2D0", Offset = "0x2F598D0", VA = "0x182F5B2D0")]
		[CompilerGenerated]
		internal static StructureElement <LoadElements>g__GetElementInstance|7_0(Structure structure, int elementNum, ElementID elementID)
		{
			return null;
		}
	}
}
