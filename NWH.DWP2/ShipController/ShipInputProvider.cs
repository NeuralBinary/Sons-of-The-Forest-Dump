using System;
using Il2CppDummyDll;
using NWH.Common.Input;
using UnityEngine;

namespace NWH.DWP2.ShipController
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	public abstract class ShipInputProvider : InputProvider
	{
		// Token: 0x0600014B RID: 331 RVA: 0x00002B1C File Offset: 0x00000D1C
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "6")]
		public virtual float Steering()
		{
			return 0f;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002B34 File Offset: 0x00000D34
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "7")]
		public virtual float Throttle()
		{
			return 0f;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "8")]
		public virtual float Throttle2()
		{
			return 0f;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002B64 File Offset: 0x00000D64
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "9")]
		public virtual float Throttle3()
		{
			return 0f;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002B7C File Offset: 0x00000D7C
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "10")]
		public virtual float Throttle4()
		{
			return 0f;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002B94 File Offset: 0x00000D94
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "11")]
		public virtual float SternThruster()
		{
			return 0f;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002BAC File Offset: 0x00000DAC
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "12")]
		public virtual float BowThruster()
		{
			return 0f;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "13")]
		public virtual float SubmarineDepth()
		{
			return 0f;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002BDC File Offset: 0x00000DDC
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "14")]
		public virtual bool EngineStartStop()
		{
			return default(bool);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
		public virtual bool Anchor()
		{
			return default(bool);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002C0C File Offset: 0x00000E0C
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x5BC460", Offset = "0x5BAA60", VA = "0x1805BC460", Slot = "16")]
		public virtual Vector2 DragObjectPosition()
		{
			return default(Vector2);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002C24 File Offset: 0x00000E24
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "17")]
		public virtual bool DragObjectModifier()
		{
			return default(bool);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2715950", Offset = "0x2713F50", VA = "0x182715950")]
		protected ShipInputProvider()
		{
		}
	}
}
