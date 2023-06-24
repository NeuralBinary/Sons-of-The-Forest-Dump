using System;
using Il2CppDummyDll;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000B6 RID: 182
	[Token(Token = "0x20000B6")]
	public struct BurstAabb
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600038F RID: 911 RVA: 0x000034C4 File Offset: 0x000016C4
		[Token(Token = "0x17000073")]
		public float4 size
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x27976D0", Offset = "0x2795CD0", VA = "0x1827976D0")]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000390 RID: 912 RVA: 0x000034DC File Offset: 0x000016DC
		[Token(Token = "0x17000074")]
		public float4 center
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x2797740", Offset = "0x2795D40", VA = "0x182797740")]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x15C8940", Offset = "0x15C6F40", VA = "0x1815C8940")]
		public BurstAabb(float4 min, float4 max)
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x2797800", Offset = "0x2795E00", VA = "0x182797800")]
		public BurstAabb(float4 v1, float4 v2, float4 v3, float margin)
		{
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x2797AD0", Offset = "0x27960D0", VA = "0x182797AD0")]
		public BurstAabb(float2 v1, float2 v2, float margin)
		{
		}

		// Token: 0x06000394 RID: 916 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x2797B90", Offset = "0x2796190", VA = "0x182797B90")]
		public BurstAabb(float4 previousPosition, float4 position, float radius)
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x000034F4 File Offset: 0x000016F4
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x2797DB0", Offset = "0x27963B0", VA = "0x182797DB0")]
		public float AverageAxisLength()
		{
			return 0f;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000350C File Offset: 0x0000170C
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x2797DF0", Offset = "0x27963F0", VA = "0x182797DF0")]
		public float MaxAxisLength()
		{
			return 0f;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x2797E90", Offset = "0x2796490", VA = "0x182797E90")]
		public void EncapsulateParticle(float4 position, float radius)
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x2798060", Offset = "0x2796660", VA = "0x182798060")]
		public void EncapsulateParticle(float4 previousPosition, float4 position, float radius)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x27983A0", Offset = "0x27969A0", VA = "0x1827983A0")]
		public void EncapsulateBounds(in BurstAabb bounds)
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x2798540", Offset = "0x2796B40", VA = "0x182798540")]
		public void Expand(float4 amount)
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x2798610", Offset = "0x2796C10", VA = "0x182798610")]
		public void Sweep(float4 velocity)
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x2798800", Offset = "0x2796E00", VA = "0x182798800")]
		public void Transform(in BurstAffineTransform transform)
		{
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x27988D0", Offset = "0x2796ED0", VA = "0x1827988D0")]
		public void Transform(in float4x4 transform)
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00003524 File Offset: 0x00001724
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x2798E50", Offset = "0x2797450", VA = "0x182798E50")]
		public BurstAabb Transformed(in BurstAffineTransform transform)
		{
			return default(BurstAabb);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000353C File Offset: 0x0000173C
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x2798E90", Offset = "0x2797490", VA = "0x182798E90")]
		public BurstAabb Transformed(in float4x4 transform)
		{
			return default(BurstAabb);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00003554 File Offset: 0x00001754
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x2798ED0", Offset = "0x27974D0", VA = "0x182798ED0")]
		public bool IntersectsAabb(in BurstAabb bounds, bool in2D = false)
		{
			return default(bool);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000356C File Offset: 0x0000176C
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x2798F50", Offset = "0x2797550", VA = "0x182798F50")]
		public bool IntersectsRay(float4 origin, float4 inv_dir, bool in2D = false)
		{
			return default(bool);
		}

		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x0")]
		public float4 min;

		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x10")]
		public float4 max;
	}
}
