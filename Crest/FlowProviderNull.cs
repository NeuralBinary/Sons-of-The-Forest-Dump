using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class FlowProviderNull : IFlowProvider
	{
		// Token: 0x0600001B RID: 27 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x9C7010", Offset = "0x9C5610", VA = "0x1809C7010", Slot = "4")]
		public int Query(int i_ownerHash, float i_minSpatialLength, Vector3[] i_queryPoints, Vector3[] o_resultFlows)
		{
			return 0;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "5")]
		public bool RetrieveSucceeded(int queryStatus)
		{
			return default(bool);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		public void UpdateQueries()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		public void CleanUp()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public FlowProviderNull()
		{
		}

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CollProviderNull Instance;
	}
}
