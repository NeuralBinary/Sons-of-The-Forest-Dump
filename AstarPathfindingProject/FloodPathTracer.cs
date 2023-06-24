using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000F1 RID: 241
	[Token(Token = "0x20000F1")]
	public class FloodPathTracer : ABPath
	{
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x00005C0C File Offset: 0x00003E0C
		[Token(Token = "0x1700013F")]
		protected override bool hasEndPoint
		{
			[Token(Token = "0x600083B")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x6D7F30", Offset = "0x6D6530", VA = "0x1806D7F30")]
		public FloodPathTracer()
		{
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x6D7FB0", Offset = "0x6D65B0", VA = "0x1806D7FB0")]
		public static FloodPathTracer Construct(Vector3 start, FloodPath flood, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x6D8070", Offset = "0x6D6670", VA = "0x1806D8070")]
		protected void Setup(Vector3 start, FloodPath flood, OnPathDelegate callback)
		{
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x6D8310", Offset = "0x6D6910", VA = "0x1806D8310", Slot = "20")]
		protected override void Reset()
		{
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x6D8380", Offset = "0x6D6980", VA = "0x1806D8380", Slot = "26")]
		protected override void Initialize()
		{
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x6D8410", Offset = "0x6D6A10", VA = "0x1806D8410", Slot = "27")]
		protected override void CalculateStep(long targetTick)
		{
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x6D8480", Offset = "0x6D6A80", VA = "0x1806D8480")]
		public void Trace(GraphNode from)
		{
		}

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		protected FloodPath flood;
	}
}
