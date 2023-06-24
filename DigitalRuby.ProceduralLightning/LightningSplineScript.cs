using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	public class LightningSplineScript : LightningBoltPathScriptBase
	{
		// Token: 0x06000157 RID: 343 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x6000157")]
		[Address(RVA = "0xA48BB0", Offset = "0xA471B0", VA = "0x180A48BB0")]
		private bool SourceChanged()
		{
			return default(bool);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000158")]
		[Address(RVA = "0xA477E0", Offset = "0xA45DE0", VA = "0x180A477E0", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000159")]
		[Address(RVA = "0xA48CF0", Offset = "0xA472F0", VA = "0x180A48CF0", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015A")]
		[Address(RVA = "0xA48D00", Offset = "0xA47300", VA = "0x180A48D00", Slot = "4")]
		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600015B")]
		[Address(RVA = "0xA49420", Offset = "0xA47A20", VA = "0x180A49420", Slot = "9")]
		protected override LightningBoltParameters OnCreateParameters()
		{
			return null;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015C")]
		[Address(RVA = "0xA494F0", Offset = "0xA47AF0", VA = "0x180A494F0")]
		public void Trigger(List<Vector3> points, bool spline)
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015D")]
		[Address(RVA = "0xA496A0", Offset = "0xA47CA0", VA = "0x180A496A0")]
		public static void PopulateSpline(List<Vector3> splinePoints, List<Vector3> sourcePoints, int generations, float distancePerSegmentHit, Camera camera)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600015E")]
		[Address(RVA = "0xA49880", Offset = "0xA47E80", VA = "0x180A49880")]
		public LightningSplineScript()
		{
		}

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		public const int MaxSplineGenerations = 5;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x200")]
		[Header("Lightning Spline Properties")]
		[Tooltip("The distance hint for each spline segment. Set to <= 0 to use the generations to determine how many spline segments to use. If > 0, it will be divided by Generations before being applied. This value is a guideline and is approximate, and not uniform on the spline.")]
		public float DistancePerSegmentHint;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x208")]
		private readonly List<Vector3> prevSourcePoints;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x210")]
		private readonly List<Vector3> sourcePoints;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x218")]
		private List<Vector3> savedSplinePoints;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x220")]
		private int previousGenerations;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x224")]
		private float previousDistancePerSegment;
	}
}
