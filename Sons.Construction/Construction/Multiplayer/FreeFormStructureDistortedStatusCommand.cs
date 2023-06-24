using System;
using Il2CppDummyDll;

namespace Construction.Multiplayer
{
	// Token: 0x02000288 RID: 648
	[Token(Token = "0x2000288")]
	public class FreeFormStructureDistortedStatusCommand : FreeFormStructureCommand
	{
		// Token: 0x060013C4 RID: 5060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013C4")]
		[Address(RVA = "0x2F5C800", Offset = "0x2F5AE00", VA = "0x182F5C800")]
		public void Init(int dbVersion, int typeID, int instanceID, bool isDistorted)
		{
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013C5")]
		[Address(RVA = "0x2F5C820", Offset = "0x2F5AE20", VA = "0x182F5C820", Slot = "4")]
		public override void Execute(ConstructionManager manager)
		{
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013C6")]
		[Address(RVA = "0x2F5C9E0", Offset = "0x2F5AFE0", VA = "0x182F5C9E0", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013C7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public FreeFormStructureDistortedStatusCommand()
		{
		}

		// Token: 0x0400099B RID: 2459
		[Token(Token = "0x400099B")]
		[FieldOffset(Offset = "0x18")]
		private int _typeID;

		// Token: 0x0400099C RID: 2460
		[Token(Token = "0x400099C")]
		[FieldOffset(Offset = "0x1C")]
		private int _instanceID;

		// Token: 0x0400099D RID: 2461
		[Token(Token = "0x400099D")]
		[FieldOffset(Offset = "0x20")]
		private bool _isDistorted;
	}
}
