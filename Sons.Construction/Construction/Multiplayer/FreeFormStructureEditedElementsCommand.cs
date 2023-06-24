using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.ConstructionBoltToken;

namespace Construction.Multiplayer
{
	// Token: 0x02000283 RID: 643
	[Token(Token = "0x2000283")]
	public class FreeFormStructureEditedElementsCommand : FreeFormStructureCommand
	{
		// Token: 0x060013B0 RID: 5040 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013B0")]
		[Address(RVA = "0x2F5BED0", Offset = "0x2F5A4D0", VA = "0x182F5BED0")]
		public void Init(int dbVersion, int typeID, int instanceID, List<ElementID> elementIDs)
		{
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013B1")]
		[Address(RVA = "0x2F5BF40", Offset = "0x2F5A540", VA = "0x182F5BF40", Slot = "4")]
		public override void Execute(ConstructionManager manager)
		{
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013B2")]
		[Address(RVA = "0x2F5BFC0", Offset = "0x2F5A5C0", VA = "0x182F5BFC0", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013B3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public FreeFormStructureEditedElementsCommand()
		{
		}

		// Token: 0x0400098E RID: 2446
		[Token(Token = "0x400098E")]
		[FieldOffset(Offset = "0x18")]
		private int _typeID;

		// Token: 0x0400098F RID: 2447
		[Token(Token = "0x400098F")]
		[FieldOffset(Offset = "0x1C")]
		private int _instanceID;

		// Token: 0x04000990 RID: 2448
		[Token(Token = "0x4000990")]
		[FieldOffset(Offset = "0x20")]
		private List<ElementID> _elementIDs;
	}
}
