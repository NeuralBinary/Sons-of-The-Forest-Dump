using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.ConstructionBoltToken;

namespace Construction.Multiplayer
{
	// Token: 0x02000284 RID: 644
	[Token(Token = "0x2000284")]
	public class FreeFormStructureEditedLinksCommand : FreeFormStructureCommand
	{
		// Token: 0x060013B4 RID: 5044 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013B4")]
		[Address(RVA = "0x2F5BED0", Offset = "0x2F5A4D0", VA = "0x182F5BED0")]
		public void Init(int dbVersion, int typeID, int instanceID, List<StructureID> Links)
		{
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013B5")]
		[Address(RVA = "0x2F5C020", Offset = "0x2F5A620", VA = "0x182F5C020", Slot = "4")]
		public override void Execute(ConstructionManager manager)
		{
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013B6")]
		[Address(RVA = "0x2F5C0A0", Offset = "0x2F5A6A0", VA = "0x182F5C0A0", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013B7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public FreeFormStructureEditedLinksCommand()
		{
		}

		// Token: 0x04000991 RID: 2449
		[Token(Token = "0x4000991")]
		[FieldOffset(Offset = "0x18")]
		private int _typeID;

		// Token: 0x04000992 RID: 2450
		[Token(Token = "0x4000992")]
		[FieldOffset(Offset = "0x1C")]
		private int _instanceID;

		// Token: 0x04000993 RID: 2451
		[Token(Token = "0x4000993")]
		[FieldOffset(Offset = "0x20")]
		private List<StructureID> _links;
	}
}
