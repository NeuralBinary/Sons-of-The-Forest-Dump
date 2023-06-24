using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x20000F5")]
	public class XPath : ABPath
	{
		// Token: 0x06000862 RID: 2146 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000862")]
		[Address(RVA = "0x6DCCD0", Offset = "0x6DB2D0", VA = "0x1806DCCD0")]
		public XPath()
		{
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x6DCD50", Offset = "0x6DB350", VA = "0x1806DCD50")]
		public new static XPath Construct(Vector3 start, Vector3 end, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x6D8310", Offset = "0x6D6910", VA = "0x1806D8310", Slot = "20")]
		protected override void Reset()
		{
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00005C6C File Offset: 0x00003E6C
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "29")]
		protected override bool EndPointGridGraphSpecialCase(GraphNode endNode)
		{
			return default(bool);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x6DCEF0", Offset = "0x6DB4F0", VA = "0x1806DCEF0", Slot = "30")]
		protected override void CompletePathIfStartIsValidTarget()
		{
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x6DCFC0", Offset = "0x6DB5C0", VA = "0x1806DCFC0")]
		private void ChangeEndNode(GraphNode target)
		{
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x6DD100", Offset = "0x6DB700", VA = "0x1806DD100", Slot = "27")]
		protected override void CalculateStep(long targetTick)
		{
		}

		// Token: 0x040005B4 RID: 1460
		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public PathEndingCondition endingCondition;
	}
}
