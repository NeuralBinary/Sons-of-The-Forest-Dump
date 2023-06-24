using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public class RichPath
	{
		// Token: 0x06000188 RID: 392 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x629ED0", Offset = "0x6284D0", VA = "0x180629ED0")]
		public RichPath()
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x629F90", Offset = "0x628590", VA = "0x180629F90")]
		public void Clear()
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x62A020", Offset = "0x628620", VA = "0x18062A020")]
		public void Initialize(Seeker seeker, Path path, bool mergePartEndpoints, bool simplificationMode)
		{
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00002BAC File Offset: 0x00000DAC
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700007C")]
		public Vector3 Endpoint
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x62AC70", Offset = "0x629270", VA = "0x18062AC70")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x62AC90", Offset = "0x629290", VA = "0x18062AC90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[Token(Token = "0x1700007D")]
		public bool CompletedAllParts
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x62ACA0", Offset = "0x6292A0", VA = "0x18062ACA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00002BDC File Offset: 0x00000DDC
		[Token(Token = "0x1700007E")]
		public bool IsLastPart
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x62ACF0", Offset = "0x6292F0", VA = "0x18062ACF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x62AD40", Offset = "0x629340", VA = "0x18062AD40")]
		public void NextPart()
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x62AD90", Offset = "0x629390", VA = "0x18062AD90")]
		public RichPathPart GetCurrentPart()
		{
			return null;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x62AE50", Offset = "0x629450", VA = "0x18062AE50")]
		public void GetRemainingPath(List<Vector3> buffer, Vector3 currentPosition, out bool requiresRepath)
		{
		}

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x10")]
		private int currentPart;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<RichPathPart> parts;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x20")]
		public Seeker seeker;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x28")]
		public ITransform transform;
	}
}
