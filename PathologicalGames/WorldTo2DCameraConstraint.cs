using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	[AddComponentMenu("Path-o-logical/UnityConstraints/Constraint- World To 2D Camera")]
	public class WorldTo2DCameraConstraint : TransformConstraint
	{
		// Token: 0x060002A8 RID: 680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x28D55D0", Offset = "0x28D3BD0", VA = "0x1828D55D0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x28D5A80", Offset = "0x28D4080", VA = "0x1828D5A80", Slot = "9")]
		protected override void OnConstraintUpdate()
		{
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x28D5E50", Offset = "0x28D4450", VA = "0x1828D5E50")]
		public WorldTo2DCameraConstraint()
		{
		}

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x80")]
		public bool vertical;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x88")]
		public Camera targetCamera;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x90")]
		public Camera orthoCamera;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x98")]
		public Vector3 offset;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0xA4")]
		public WorldTo2DCameraConstraint.OFFSET_MODE offsetMode;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0xA8")]
		public WorldTo2DCameraConstraint.OFFSCREEN_MODE offScreenMode;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0xAC")]
		public Vector2 offscreenThreasholdW;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0xB4")]
		public Vector2 offscreenThreasholdH;

		// Token: 0x02000066 RID: 102
		[Token(Token = "0x2000066")]
		public enum OFFSET_MODE
		{
			// Token: 0x04000190 RID: 400
			[Token(Token = "0x4000190")]
			WorldSpace,
			// Token: 0x04000191 RID: 401
			[Token(Token = "0x4000191")]
			ViewportSpace
		}

		// Token: 0x02000067 RID: 103
		[Token(Token = "0x2000067")]
		public enum OFFSCREEN_MODE
		{
			// Token: 0x04000193 RID: 403
			[Token(Token = "0x4000193")]
			Constrain,
			// Token: 0x04000194 RID: 404
			[Token(Token = "0x4000194")]
			Limit,
			// Token: 0x04000195 RID: 405
			[Token(Token = "0x4000195")]
			DoNothing
		}
	}
}
