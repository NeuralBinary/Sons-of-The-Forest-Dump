using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.ConstructionBoltToken;

namespace Construction.Multiplayer
{
	// Token: 0x02000286 RID: 646
	[Token(Token = "0x2000286")]
	public class FreeFormStructureCascadeRepositionCommand : FreeFormStructureCommand
	{
		// Token: 0x060013BC RID: 5052 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013BC")]
		[Address(RVA = "0x77B7F0", Offset = "0x779DF0", VA = "0x18077B7F0")]
		public void Init(int dbVersion, List<StructureID> structureIDs)
		{
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013BD")]
		[Address(RVA = "0x2F5C310", Offset = "0x2F5A910", VA = "0x182F5C310", Slot = "4")]
		public override void Execute(ConstructionManager manager)
		{
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013BE")]
		[Address(RVA = "0x2F5C610", Offset = "0x2F5AC10", VA = "0x182F5C610", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013BF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public FreeFormStructureCascadeRepositionCommand()
		{
		}

		// Token: 0x04000998 RID: 2456
		[Token(Token = "0x4000998")]
		[FieldOffset(Offset = "0x18")]
		private List<StructureID> _structureIDs;
	}
}
