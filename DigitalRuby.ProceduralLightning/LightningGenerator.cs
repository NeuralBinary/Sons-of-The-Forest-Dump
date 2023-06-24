using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	public class LightningGenerator
	{
		// Token: 0x06000138 RID: 312 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000138")]
		[Address(RVA = "0xA454A0", Offset = "0xA43AA0", VA = "0x180A454A0")]
		private void GetPerpendicularVector(ref Vector3 directionNormalized, out Vector3 side)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000139")]
		[Address(RVA = "0xA45700", Offset = "0xA43D00", VA = "0x180A45700", Slot = "4")]
		protected virtual void OnGenerateLightningBolt(LightningBolt bolt, Vector3 start, Vector3 end, LightningBoltParameters parameters)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x600013A")]
		[Address(RVA = "0xA45780", Offset = "0xA43D80", VA = "0x180A45780")]
		public bool ShouldCreateFork(LightningBoltParameters parameters, int generation, int totalGenerations)
		{
			return default(bool);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013B")]
		[Address(RVA = "0xA457F0", Offset = "0xA43DF0", VA = "0x180A457F0")]
		public void CreateFork(LightningBolt bolt, LightningBoltParameters parameters, int generation, int totalGenerations, Vector3 start, Vector3 midPoint)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013C")]
		[Address(RVA = "0xA459F0", Offset = "0xA43FF0", VA = "0x180A459F0")]
		public void GenerateLightningBoltStandard(LightningBolt bolt, Vector3 start, Vector3 end, int generation, int totalGenerations, float offsetAmount, LightningBoltParameters parameters)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x600013D")]
		[Address(RVA = "0xA46020", Offset = "0xA44620", VA = "0x180A46020")]
		public Vector3 RandomDirection3D(System.Random random)
		{
			return default(Vector3);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x600013E")]
		[Address(RVA = "0xA46140", Offset = "0xA44740", VA = "0x180A46140")]
		public Vector3 RandomDirection2D(System.Random random)
		{
			return default(Vector3);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x600013F")]
		[Address(RVA = "0xA461B0", Offset = "0xA447B0", VA = "0x180A461B0")]
		public Vector3 RandomDirection2DXZ(System.Random random)
		{
			return default(Vector3);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000140")]
		[Address(RVA = "0xA46220", Offset = "0xA44820", VA = "0x180A46220")]
		public void RandomVector(LightningBolt bolt, ref Vector3 start, ref Vector3 end, float offsetAmount, System.Random random, out Vector3 result)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000141")]
		[Address(RVA = "0xA46880", Offset = "0xA44E80", VA = "0x180A46880")]
		public void GenerateLightningBolt(LightningBolt bolt, LightningBoltParameters parameters)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000142")]
		[Address(RVA = "0xA468C0", Offset = "0xA44EC0", VA = "0x180A468C0")]
		public void GenerateLightningBolt(LightningBolt bolt, LightningBoltParameters parameters, out Vector3 start, out Vector3 end)
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public LightningGenerator()
		{
		}

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		internal const float oneOver255 = 0.003921569f;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		internal const float mainTrunkMultiplier = 0.003921569f;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LightningGenerator GeneratorInstance;
	}
}
