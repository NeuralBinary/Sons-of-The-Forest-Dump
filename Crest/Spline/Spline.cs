using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest.Spline
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	[ExecuteAlways]
	public class Spline : MonoBehaviour
	{
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x170000B9")]
		public float Radius
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x170000BA")]
		public int Subdivisions
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x674020", Offset = "0x672620", VA = "0x180674020")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x170000BB")]
		public int SmoothingIterations
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030B")]
		[Address(RVA = "0xA25CE0", Offset = "0xA242E0", VA = "0x180A25CE0")]
		public Spline()
		{
		}

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private int _version;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Connect start and end point to close spline into a loop. Requires at least 3 spline points.")]
		public bool _closed;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _radius;

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x2C")]
		[Delayed]
		[SerializeField]
		private int _subdivisions;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Delayed]
		private int _smoothingIterations;
	}
}
