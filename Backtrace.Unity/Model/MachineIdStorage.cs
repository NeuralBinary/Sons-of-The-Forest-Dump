using System;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	internal class MachineIdStorage
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x7540C0", Offset = "0x7526C0", VA = "0x1807540C0")]
		internal string GenerateMachineId()
		{
			return null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x7542C0", Offset = "0x7528C0", VA = "0x1807542C0")]
		private string FetchMachineIdFromStorage()
		{
			return null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x754300", Offset = "0x752900", VA = "0x180754300")]
		private void StoreMachineId(string machineId)
		{
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x754340", Offset = "0x752940", VA = "0x180754340", Slot = "4")]
		protected virtual string UseUnityIdentifier()
		{
			return null;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x754420", Offset = "0x752A20", VA = "0x180754420", Slot = "5")]
		protected virtual string UseNetworkingIdentifier()
		{
			return null;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public MachineIdStorage()
		{
		}

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		internal const string MachineIdentifierKey = "backtrace-machine-id";
	}
}
