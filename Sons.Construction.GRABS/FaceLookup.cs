using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public class FaceLookup : IFaceLookup
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000275C File Offset: 0x0000095C
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000052")]
		public float MaxGrabDepth
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x623BB0", Offset = "0x6221B0", VA = "0x180623BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000053")]
		public IAimRayProvider AimRayProvider
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000054")]
		public ITargetFaceProvider TargetFaceProvider
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2D941D0", Offset = "0x2D927D0", VA = "0x182D941D0", Slot = "4")]
		public bool TryGetTargetFace(out BlueprintFace targetFace)
		{
			return default(bool);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2D94480", Offset = "0x2D92A80", VA = "0x182D94480")]
		private bool TryFindClosestFaceInBlueprint(Blueprint blueprint, out BlueprintFace targetFace, out float targetFaceDepth)
		{
			return default(bool);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public FaceLookup()
		{
		}

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x10")]
		private float _closestGrabDepth;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x14")]
		private Ray _aimRay;
	}
}
