using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000F4 RID: 244
	[Token(Token = "0x20000F4")]
	public class RandomPath : ABPath
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00005C3C File Offset: 0x00003E3C
		[Token(Token = "0x17000141")]
		public override bool FloodingPath
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00005C54 File Offset: 0x00003E54
		[Token(Token = "0x17000142")]
		protected override bool hasEndPoint
		{
			[Token(Token = "0x6000859")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x6DBE80", Offset = "0x6DA480", VA = "0x1806DBE80", Slot = "20")]
		protected override void Reset()
		{
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x6D6AE0", Offset = "0x6D50E0", VA = "0x1806D6AE0")]
		public RandomPath()
		{
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x6DBFC0", Offset = "0x6DA5C0", VA = "0x1806DBFC0")]
		public static RandomPath Construct(Vector3 start, int length, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x6DC080", Offset = "0x6DA680", VA = "0x1806DC080")]
		protected RandomPath Setup(Vector3 start, int length, OnPathDelegate callback)
		{
			return null;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x6DC240", Offset = "0x6DA840", VA = "0x1806DC240", Slot = "23")]
		protected override void ReturnPath()
		{
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x6DC3E0", Offset = "0x6DA9E0", VA = "0x1806DC3E0", Slot = "24")]
		protected override void Prepare()
		{
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x6DC770", Offset = "0x6DAD70", VA = "0x1806DC770", Slot = "26")]
		protected override void Initialize()
		{
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x6DCA00", Offset = "0x6DB000", VA = "0x1806DCA00", Slot = "27")]
		protected override void CalculateStep(long targetTick)
		{
		}

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public int searchLength;

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public int spread;

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public float aimStrength;

		// Token: 0x040005AE RID: 1454
		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private PathNode chosenNodeR;

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private PathNode maxGScoreNodeR;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private int maxGScore;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public Vector3 aim;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int nodesEvaluatedRep;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private readonly System.Random rnd;
	}
}
