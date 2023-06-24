using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Attributes
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	internal sealed class MachineAttributeProvider : IScopeAttributeProvider
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x7622B0", Offset = "0x7608B0", VA = "0x1807622B0", Slot = "4")]
		public void GetAttributes(IDictionary<string, string> attributes)
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x762350", Offset = "0x760950", VA = "0x180762350")]
		private void IncludeOsInformation(IDictionary<string, string> attributes)
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x762CB0", Offset = "0x7612B0", VA = "0x180762CB0")]
		private void IncludeGraphicCardInformation(IDictionary<string, string> attributes)
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x7635B0", Offset = "0x761BB0", VA = "0x1807635B0")]
		public MachineAttributeProvider()
		{
		}

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x10")]
		private readonly MachineIdStorage _machineIdStorage;
	}
}
