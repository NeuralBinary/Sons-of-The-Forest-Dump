using System;
using Il2CppDummyDll;

namespace Construction.Multiplayer
{
	// Token: 0x02000287 RID: 647
	[Token(Token = "0x2000287")]
	public class FreeFormStructureDestroyedCommand : FreeFormStructureCommand
	{
		// Token: 0x060013C0 RID: 5056 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013C0")]
		[Address(RVA = "0x2F5C670", Offset = "0x2F5AC70", VA = "0x182F5C670")]
		public void Init(int dbVersion, int typeID, int instanceID)
		{
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013C1")]
		[Address(RVA = "0x2F5C680", Offset = "0x2F5AC80", VA = "0x182F5C680", Slot = "4")]
		public override void Execute(ConstructionManager manager)
		{
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013C2")]
		[Address(RVA = "0x2F5C7A0", Offset = "0x2F5ADA0", VA = "0x182F5C7A0", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013C3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public FreeFormStructureDestroyedCommand()
		{
		}

		// Token: 0x04000999 RID: 2457
		[Token(Token = "0x4000999")]
		[FieldOffset(Offset = "0x18")]
		private int _typeID;

		// Token: 0x0400099A RID: 2458
		[Token(Token = "0x400099A")]
		[FieldOffset(Offset = "0x1C")]
		private int _instanceID;
	}
}
